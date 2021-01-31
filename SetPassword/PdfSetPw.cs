using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using iText.Kernel;
using iText.Kernel.Pdf;

namespace SetPassword
{
    public class PdfSetPw
    {



        public void Set(string arquivo, string senha)
        {

            var item = arquivo;


            if (!File.Exists(item)) return;

            try
            {

                EncryptionProperties encryptionProperties = new EncryptionProperties();

                var senhabyte = Encoding.ASCII.GetBytes(senha);

                encryptionProperties.SetStandardEncryption(senhabyte, senhabyte, EncryptionConstants.ALLOW_PRINTING, EncryptionConstants.ENCRYPTION_AES_128);

                using (Stream input = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var info = new FileInfo(item);

                    var nameFile = Path.GetFileName(arquivo);

                    var pdfencrypted = info.Directory + "\\encrypted.pdf";

                    using (Stream output = new FileStream(pdfencrypted, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        iText.Kernel.Pdf.PdfReader reader = new PdfReader(input);
                        PdfEncryptor.Encrypt(reader, output, encryptionProperties);

                    }

                    //  File.Delete(item);
                    // File.Move(pdfencrypted, item);
                }
            }
            catch (iText.Kernel.PdfException e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}



