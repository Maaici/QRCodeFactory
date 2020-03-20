using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using QRCoder;

namespace QRCodeFactory
{
    public static class QrCodeFactory
    {
        public static bool GenerateCoder(string codeStr,string path) {
            if (string.IsNullOrWhiteSpace(codeStr) || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }
            var newPath = Path.Combine(path, "二维码_"+DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
                Directory.CreateDirectory(Path.Combine(newPath,"单个"));
                Directory.CreateDirectory(Path.Combine(newPath,"合并后"));
            }
            try
            {
                var codes = codeStr.Split(',').Distinct();
                foreach (var item in codes)
                {
                    if (string.IsNullOrWhiteSpace(item))
                        continue;
                    string code = item.Trim();
                    SaveCode(code, Path.Combine( newPath, "单个", $"{item}.jpg"));
                }
                return true;
            }
            catch (Exception ex)
            {
                //出现异常全部删掉
                Directory.Delete(newPath);
                return false;
            }
        }

        public static bool GenerateCoder(List<string> codes, string path)
        {
            if (codes == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }
            var newPath = Path.Combine(path, "二维码_" + DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
                Directory.CreateDirectory(Path.Combine(newPath, "单个"));
                Directory.CreateDirectory(Path.Combine(newPath, "合并后"));
            }
            try
            {
                foreach (var item in codes)
                {
                    if (string.IsNullOrWhiteSpace(item))
                        continue;
                    string code = item.Trim();
                    SaveCode(code, Path.Combine(newPath, "单个", $"{item}.jpg"));
                }
                return true;
            }
            catch (Exception ex)
            {
                //出现异常全部删掉
                Directory.Delete(newPath);
                return false;
            }
        }

        private static void SaveCode(string strCode ,string fileName) {
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(10, Color.Black, Color.White, null, 15, 20, true);
            using (Stream stream = new FileStream(fileName, FileMode.Create)) { 
                qrCodeImage.Save(stream, ImageFormat.Jpeg);
            }
        }
    }
}
