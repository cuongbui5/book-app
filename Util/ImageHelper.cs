using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Util
{
    class ImageHelper
    {
       public static Image byteToImage(byte[] data)
        {
            if (data != null && data.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                  return Image.FromStream(ms);
                }
            }
            return null;
           
        }
    }
}
