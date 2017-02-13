using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompressJSON
{
    public class Helper
    {
        public static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        public static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        public static string Compress3(string s)
        {
            var bytes = Encoding.Unicode.GetBytes(s);
            using (var msi = new System.IO.MemoryStream(bytes))
            using (var mso = new System.IO.MemoryStream())
            {
                using (var gs = new System.IO.Compression.GZipStream(mso, System.IO.Compression.CompressionMode.Compress))
                {
                    msi.CopyTo(gs);
                }
                return Convert.ToBase64String(mso.ToArray());
            }
        }

        public static string DeCompress3(string s)
        {
            var bytes = Convert.FromBase64String(s);
            using (var msi = new System.IO.MemoryStream(bytes))
            using (var mso = new System.IO.MemoryStream())
            {
                using (var gs = new System.IO.Compression.GZipStream(msi, System.IO.Compression.CompressionMode.Decompress))
                {
                    gs.CopyTo(mso);
                }
                return Encoding.Unicode.GetString(mso.ToArray());
            }
        }
        public static string Compress2(string value)
        {
            //Transform string into byte[] 
            byte[] byteArray = new byte[value.Length];
            int indexBA = 0;
            foreach (char item in value.ToCharArray())
            {
                byteArray[indexBA++] = (byte)item;
            }

            //Prepare for compress
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.Compression.GZipStream sw = new System.IO.Compression.GZipStream(ms,
            System.IO.Compression.CompressionMode.Compress);

            //Compress
            sw.Write(byteArray, 0, byteArray.Length);
            //Close, DO NOT FLUSH cause bytes will go missing...
            sw.Close();

            //Transform byte[] zip data to string
            byteArray = ms.ToArray();
            System.Text.StringBuilder sB = new System.Text.StringBuilder(byteArray.Length);

            ms.Close();
            sw.Dispose();
            ms.Dispose();

            string str = System.Text.Encoding.UTF7.GetString(byteArray);
            return str;

            //foreach (byte item in byteArray)
            //{
            //    sB.Append((char)item);
            //}

            return sB.ToString();
        }
        public static string DeCompress2(string sData)
        {
            byte[] byteArray = new byte[sData.Length];

            int indexBa = 0;
            foreach (char item in sData)
                byteArray[indexBa++] = (byte)item;

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(byteArray);
            System.IO.Compression.GZipStream gZipStream = new System.IO.Compression.GZipStream(memoryStream, System.IO.Compression.CompressionMode.Decompress);

            byteArray = new byte[1024];

            StringBuilder stringBuilder = new StringBuilder();

            ; int readBytes;
            while ((readBytes = gZipStream.Read(byteArray, 0, byteArray.Length)) != 0)
            {
                for (int i = 0; i < readBytes; i++) stringBuilder.Append((char)byteArray[i]);
            }
            gZipStream.Close(); memoryStream.Close(); gZipStream.Dispose(); memoryStream.Dispose(); return stringBuilder.ToString();
        }

        public static string Compress(string strInput)
        {
            try
            {
                byte[] bytData = System.Text.Encoding.UTF8.GetBytes(strInput);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                System.IO.Stream s = new ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream(ms);
                s.Write(bytData, 0, bytData.Length);
                s.Close();
                byte[] compressedData = (byte[])ms.ToArray();
                return ConvertByteToString(compressedData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static string DeCompress(string strInput)
        {
            byte[] bytInput = ConvertStringToByte(strInput);
            string strResult = "";
            int totalLength = 1;
            byte[] writeData = new byte[4096];
            System.IO.Stream s2 = new ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream(new System.IO.MemoryStream(bytInput));

            try
            {
                while (true)
                {
                    int size = s2.Read(writeData, 0, totalLength);
                    if (size > 0)
                    {
                        totalLength += size;
                        strResult += System.Text.Encoding.ASCII.GetString(writeData, 0,
                        size);
                    }
                    else
                    {
                        break;
                    }
                }
                s2.Close();
                return strResult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return strResult;
            }
        }

        public static byte[] ConvertStringToByte(string strInput)
        {
            byte[] byteArray = new byte[strInput.Length];

            int indexBa = 0;
            foreach (char item in strInput)
                byteArray[indexBa++] = (byte)item;
            return byteArray;
        }
        public static string ConvertByteToString(byte[] compressedData)
        {
            System.Text.StringBuilder sB = new System.Text.StringBuilder(compressedData.Length);
            foreach (byte item in compressedData)
            {
                sB.Append((char)item);
            }
            return sB.ToString();
        }
    }
}
