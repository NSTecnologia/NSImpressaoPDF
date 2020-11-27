using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSImpressaoPDF
{
    public class Impressao
    {
        public static void Imprimir(string p_pathFilePdf)
        {

            try
            {

                FileInfo file = new FileInfo(p_pathFilePdf);

                if (file.Exists)
                {

                    Process process = new Process();
                    Process objP = new Process();

                    objP.StartInfo.FileName = p_pathFilePdf;

                    objP.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; //Hide the window.
                    objP.StartInfo.Verb = "print";
                    objP.StartInfo.CreateNoWindow = true;
                    objP.Start();

                    objP.CloseMainWindow();
                }
                else
                {
                    MessageBox.Show("Arquivo não existe.", "Erro");
                }

            }
            catch (Exception ex)
            {


            }

        }
    }
}
