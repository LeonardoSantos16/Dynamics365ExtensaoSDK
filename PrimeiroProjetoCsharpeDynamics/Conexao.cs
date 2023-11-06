using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoCsharpeDynamics
{
    public class Conexao // classe de conexão ao dynamics
    {
        private static CrmServiceClient crmServiceClientTreinamento; // armazena o conteúdo da conexão
        // AppId = e61fc53c-656f-ee11-8178-0022483715b6;
        // AppId = 6c540d8d-a99b-42e4-837a-93f59decc366
        // RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
        public CrmServiceClient ObterConexao() // método que devolve uma CrmServiceCliente
            {
                 //variável contendo a ConnectionString
                   var connectionStringCRM = @"AuthType=OAuth;
                   Username = 125111377116@ulife.com.br;
                   Password = 280202;
                   AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
                   RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
                   Url = https://org73fcfb64.crm2.dynamics.com/main.aspx;";

            if (crmServiceClientTreinamento == null)
            {
                try
                {
                   // System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    crmServiceClientTreinamento = new CrmServiceClient(connectionStringCRM);
                    if (crmServiceClientTreinamento.IsReady)
                    {
                        Console.WriteLine("Conexão bem-sucedida ao Dynamics 365.");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Conexão mal sucedida.");
                        Console.ReadKey();

                    }
                }
                catch (AggregateException ae)
                {
                    foreach (var innerException in ae.InnerExceptions)
                    {
                        Console.WriteLine("Erro ao criar a conexão CRM: " + innerException.Message);
                        Console.ReadKey();
                    }
                }
            }
            return crmServiceClientTreinamento;
        }
    }

            
       /* public CrmServiceClient ObterConexao()
        {
            if (crmServiceClientTreinamento == null)
            {
                try
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    var connectionStringCRM = "AuthType=OAuth;" +
                        "Username=leodsmf_gmail.com#EXT#@leodsmfgmail.onmicrosoft.com;" +
                        "Password=Cavalomanco21_; SkipDiscovery=True;" +
                        "AppId=e61fc53c-656f-ee11-8178-0022483715b6;" +
                        "RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;" +
                        "Url=https://orgc7c356c7.crm2.dynamics.com/main.aspx;";

                    crmServiceClientTreinamento = new CrmServiceClient(connectionStringCRM);
                    Console.WriteLine("VASCO DA GAMA E NADA MAIS");
                }
                catch (Exception ex)
                {
                    // Lidar com a exceção, por exemplo, registrando-a ou lançando uma exceção personalizada.
                    throw new Exception("Erro ao criar a conexão CRM: " + ex.Message);
                }
            }
            return crmServiceClientTreinamento;
        }
       */
    
    

}
