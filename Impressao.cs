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
        public static void Imprimir(string caminhoPDF, string nomeImpressora)
        {
            try
            {
                FileInfo file = new FileInfo(caminhoPDF);

                if (file.Exists)
                {
                    Process objP = new Process();

                    objP.StartInfo.FileName = caminhoPDF;
                    objP.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; //Hide the window.
                    objP.StartInfo.CreateNoWindow = false;

                    if (!String.IsNullOrEmpty(nomeImpressora))
                    {
                        objP.StartInfo.Verb = "printto";
                        objP.StartInfo.Arguments = "\"" + nomeImpressora + "\"";
                    }
                    else
                        objP.StartInfo.Verb = "print";
                    
                    
                    objP.Start();

                    objP.CloseMainWindow();
                }
                else
                    MessageBox.Show("Arquivo pdf não existe", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gerar impressão", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

    }
}
