using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoBareseRestaurantes
{
    internal class Util
    {
        public static int CodigoCliente { get; set; }
        public static string Descricao { get; set; }
        public const string CaminhoLog = @"C:\Ultrasoft\log.txt";
        public static void GravaErroLog(string msg, string nomemetodo)
        {
            try
            {
                bool internet = IsConnectedToInternet();
                if (File.Exists(CaminhoLog))
                {
                    DateTime data = DateTime.Now;
                    StreamWriter log = new StreamWriter(CaminhoLog, true);
                    log.AutoFlush = true;
                    log.WriteLine(msg + " " + nomemetodo + "  " + data);
                    log.Close();
                    throw new Exception("Atenção!!!\n  Por favor verifique  os Parametros de sua Operação antes de prosseguir.\n Caso esta menssagem volte a se mostrar por favor Contate o Suporte");
                }
                else
                {
                    DateTime data = DateTime.Now;
                    var stream = File.Create(CaminhoLog);
                    stream.Close();

                    StreamWriter log = new StreamWriter(CaminhoLog);
                    log.AutoFlush = true;
                    log.WriteLine(msg + data);
                    log.Close();
                    return;
                }
            }
            catch (Exception ex)
            {

            }
        }
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool IsConnectedToInternet()
        {
            bool result = false;
            try
            {
                int Desc;
                result = InternetGetConnectedState(out Desc, 0);
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
