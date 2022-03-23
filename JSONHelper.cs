using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Strat_Assistant
{
    public class LocalData
    {
        public bool CreateWizardOn { get; set; }
        public bool Updated { get; set; }
    }

    public class JSONHelper
    {
        //Write vars to json file
        public void JsonSerialize(LocalData localData)
        {
            try
            {
                File.WriteAllText(Global.localDataFilePath, JsonConvert.SerializeObject(localData, Formatting.Indented, new Newtonsoft.Json.Converters.StringEnumConverter()));
            }
            catch(Exception ex)
            {
                Global.LogError(ex);
            }
        }

        //Read vars from Json file
        public LocalData JsonDeserialize()
        {
            try
            {
                return JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(Global.localDataFilePath), new Newtonsoft.Json.Converters.StringEnumConverter());
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
                return null;
            }
        }
    }
}
