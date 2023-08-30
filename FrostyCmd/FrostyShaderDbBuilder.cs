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

            //build the db
            using (NativeWriter writer = new NativeWriter(new MemoryStream()))
            {

            }
        }
    }
}
