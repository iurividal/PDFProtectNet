using System;

namespace PDFProtectNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = "Novo";


            Console.WriteLine("Bem vindo");

            do
            {

                Console.WriteLine("Informe o caminho do pdf");
                var arquvio = Console.ReadLine();

                Console.WriteLine("Certo, agora me informe a senha");
                var senha = Console.ReadLine();

                SetPassword.PdfSetPw pw = new SetPassword.PdfSetPw();
                pw.Set(arquvio, senha);

                Console.WriteLine("Arquivo está protegido");
                Console.WriteLine("Digite Novo para proteger um novo arquivo ou Sair para fizanar a sessão");
                option = Console.ReadLine();

            } while (option != "Sair");


        }
    }
}
