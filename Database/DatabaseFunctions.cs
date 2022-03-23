using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Mapping;
using MySql;
using Strat_Assistant;
using LinqToDB.Common;
using System.Windows.Forms;

namespace Strat_Assistant
{
    class DatabaseFunctions
    {
        [Table(Name = "strats")]
        public class Strats
        {
            [Column, NotNull, PrimaryKey, Identity]
            public int ID { get; set; }

            [Column(Length = 50), NotNull]
            public string Map { get; set; }

            [Column(Length = 50), NotNull]
            public string Site { get; set; }

            [Column, NotNull]
            public bool IsAttack { get; set; }

            [Column(Length = 50), NotNull]
            public string Strat { get; set; }

            [Column(Length = 50), NotNull]
            public string OP { get; set; }

            [Column(DataType = DataType.Text), NotNull]
            public string OPText { get; set; }

            [Column(Length = 255), NotNull]
            public string Metadata { get; set; }
        }

        [Table(Name = "errorlog")]
        public class ErrorLog
        {
            [Column, NotNull, Identity, PrimaryKey]
            public int Id { get; set; }

            [Column(DataType = DataType.Text), Nullable]
            public string Message { get; set; }

            [Column(DataType = DataType.Text), Nullable]
            public string StackTrace { get; set; }

            [Column(Length = 100)]
            public DateTime Time { get; set; }
        }

        public class DBStrats : LinqToDB.Data.DataConnection
        {
#if DEBUG
            public DBStrats() : base("StratDebug") { }
#elif RELEASE
            public DBStrats() : base("Strat") { }
#endif

            public ITable<Strats> Strats { get { return GetTable<Strats>(); } }
            public ITable<ErrorLog> ErrorLog { get { return GetTable<ErrorLog>(); } }
        }

        public static async Task CreateStrats()
        {
            using (var db = new DBStrats())
            {
                try
                {
                    Console.WriteLine(db.ConnectionString);
                    await db.CreateTableAsync<Strats>();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Caught a failed creation of the Strats table");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static async Task CreateErrorLog()
        {
            using (var db = new DBStrats())
            {
                try
                {
                    await db.CreateTableAsync<ErrorLog>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught a failed creation of the ErrorLog table");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static async Task ErrorLogInsert(ErrorLog errorlog)
        {
            try
            {
                using (var db = new DBStrats())
                {
                    await db.InsertAsync(errorlog);
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        public static async Task<bool> UpdateStrats(Strats strat)
        {
            try
            {
                using (var db = new DBStrats())
                {
                    if(strat.ID <= 0)
                    {
                        throw new Exception("StratID is less than or equal to 0. This likely means you are trying to edit a strat that doesn't exist.");
                    }
                    string side = "";
                    if (strat.IsAttack)
                    {
                        side = "Attacker";
                    }
                    else
                    {
                        side = "Defender";
                    }

                    strat.Metadata = $"{strat.Map},{strat.Site},{side},{strat.Strat},{strat.OP}";
                    await db.UpdateAsync(strat);
                    return true;
                }
            }
            catch(Exception ex)
            {
                Global.LogError(ex);
                return false;
            }
        }

        public static async Task<bool> StratInsert(Strats strat)
        {
            try
            {
                using (var db = new DBStrats())
                {
                    string side = "";
                    if(strat.IsAttack)
                    {
                        side = "Attacker";
                    }
                    else
                    {
                        side = "Defender";
                    }

                    strat.Metadata = $"{strat.Map},{strat.Site},{side},{strat.Strat},{strat.OP}";
                    await db.InsertAsync(strat);
                    return true;
                }
            }

            catch(Exception ex)
            {
                Global.LogError(ex);
                return false;
            }
        }

        public static List<string> GetMetadata()
        {
            try
            {
                using (var db = new DBStrats())
                {
                    var query = from s in db.Strats
                                select s.Metadata;

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
                return null;
            }
        }

        public static List<string> GetStratNames(string map, string site, bool isAttacker)
        {
            try
            {
                using (var db = new DBStrats())
                {
                    var query = from s in db.Strats
                                where s.Map == map && s.Site == site && s.IsAttack == isAttacker
                                select s.Strat;
                    return query.ToList();
                }
            }
            catch(Exception ex)
            {
                Global.LogError(ex);
                return null;
            }
        }

        public static List<string> GetOps(string map, string site, bool isAttacker, string strat)
        {
            try
            {
                using (var db = new DBStrats())
                {
                    var query = from s in db.Strats
                                where s.Map == map && s.Site == site && s.IsAttack == isAttacker && s.Strat == strat
                                select s.OP;
                    return query.ToList();
                }
            }
            catch(Exception ex)
            {
                Global.LogError(ex);
                return null;
            }
        }

        public static string GetOpText(string map, string site, bool isAttacker, string strat, string op)
        {
            try
            {
                using (var db = new DBStrats())
                {
                    var query = from s in db.Strats
                                where s.Map == map && s.Site == site && s.IsAttack == isAttacker && s.Strat == strat && s.OP == op
                                select s.OPText;
                    return query.First();
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
                return null;
            }
        }

        public static int GetID(string map, string site, bool isAttacker, string strat, string op)
        {
            try
            {
                using (var db = new DBStrats())
                {
                    var query = from s in db.Strats
                                where s.Map == map && s.Site == site && s.IsAttack == isAttacker && s.Strat == strat && s.OP == op
                                select s.ID;

                    return query.First();
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
                return 0;
            }
        }
    }
}
