using FrostySdk.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrostyCmd
{
    public class FrostyShaderDbBuilder
    {
        public void BuildDb(string inputPath)
        {
            //gather input binaries from path
            string[] paths = Directory.GetFiles(inputPath);
            int index;
            string[] binarynames = paths; //temporarily store full paths in here

            for (int i = 0; i < paths.Length; i++)
            {
                index = paths[i].LastIndexOf("\\");
                binarynames[i] = paths[i].Remove(0, index + 2); //strip path
            };



            //build the db
            using (NativeWriter writer = new NativeWriter(new MemoryStream()))
            {

            }
        }
    }
}
