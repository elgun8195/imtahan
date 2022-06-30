using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Backend.Helpers
{
    public static class Helper
    {
        public static bool IsImage(this IFormFile formFile)
        {
            return formFile.ContentType.Contains("image/");
        }
        public static bool CheckSize(this IFormFile formFile,int kb)
        {
            return formFile.Length/1024>kb;
        }

        public static void DeleteImage( IWebHostEnvironment env,string file,string folder)
        {
            string path = env.WebRootPath;
            string result = Path.Combine(path,file,folder);

            if (System.IO.File.Exists(result))
            {
                System.IO.File.Delete(result);
            }
        }
    }


    public enum Roless
    {
        Member,Admin,SuperAdmin
    }
}
