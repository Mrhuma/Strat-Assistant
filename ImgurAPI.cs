using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;

namespace Strat_Assistant
{
    class ImgurAPI
    {
        public async Task<string> UploadImage(string imagePath)
        {
            try
            {
                var client = new ImgurClient("f9fb6ab7d7b536d", "d26cf9304548ed2361ffbeab284e7df39ec0674e");
                var endpoint = new ImageEndpoint(client);
                IImage image;
                using (var fs = new FileStream($@"{imagePath}", FileMode.Open))
                {
                    image = await endpoint.UploadImageStreamAsync(fs);
                }
                Debug.Write("Image uploaded. Image Url: " + image.Link);
                return image.Link;
            }
            catch (ImgurException imgurEx)
            {
                Global.LogError(imgurEx);
                return "";
            }
        }
    }
}
