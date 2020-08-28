using System;

namespace _7a_quinzena
{
    public class Program
    {
        class computer
        {
            //creating properties
            public string cpu { get; set; }
            public string gpu { get; set; }
            public string ram { get; set; }
            public string motherboard { get; set; }
            public int powerSupplyWatts { get; set; }
            public string pcCase { get; set; }
            public string hdCapacity { get; set; }
            public string changeStatusPc;
            public string statusResponse;

            // private string turningMusicOn;
            // private string blzTaBom;

            public void turnPcOnOff(string pTurnOnOffPc)
            {
                this.changeStatusPc = pTurnOnOffPc;
                Console.WriteLine("Seu computador está: " + changeStatusPc);
            }

            // public void turningMusicOn()
            // {
            //     Console.WriteLine("Programas iniciados. Agora, tocando a música: 'Alice in Chains - Man in the box'")
            // }

            // public void blzTaBom()
            // {
            //     Console.WriteLine("Ok, beleza, ta bom, certo, entendi, tranquilo, como vc quiser.")
            // }
        }

        public static void Main()
        {
            computer obj = new computer();

            Console.WriteLine("Digite o modelo de sua CPU (formato: 'AMD Ryzen 5 1600AF'): ");
            obj.cpu = Console.ReadLine();

            Console.WriteLine("Digite o modelo de sua Placa de Vídeo (formato: 'Asus RX 580 4GB'): ");
            obj.gpu = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de Memória RAM (formato: '2x8GB 2400'): ");
            obj.ram = Console.ReadLine();

            Console.WriteLine("Digite o modelo de sua Placa mãe (formato: 'Asus EX-A320M-Gaming'): ");
            obj.motherboard = Console.ReadLine();

            Console.WriteLine("Digite quantos Watts sua fonte possui (formato: '600'): ");
            obj.powerSupplyWatts = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o modelo de seu gabinete (formato: 'Fortrek Centurion Gamer'): ");
            obj.pcCase = Console.ReadLine();

            Console.WriteLine("Digite quantos GB totais seu PC tem (formato: '1.240TB'): ");
            obj.hdCapacity = Console.ReadLine();

            Console.WriteLine("Seu computador irá iniciar. Deseja tocar uma música? (formato: S / N)");
            var response = Console.ReadLine();

            //showing the method to initialize the computer
            // Console.WriteLine(turningOnPC);

            //show in console the datas inserted by the user
            Console.WriteLine("Seu processador é: " + obj.cpu);
            Console.WriteLine("Sua placa de vídeo é: " + obj.gpu);
            Console.WriteLine("Você tem: " + obj.ram + " de RAM");
            Console.WriteLine("Sua placa mãe é: " + obj.motherboard);
            Console.WriteLine("Sua fonte possui: " + obj.powerSupplyWatts + "W de potência");
            Console.WriteLine("O modelo de seu gabinete é: " + obj.pcCase);
            Console.WriteLine("Seu computador possui: " + obj.hdCapacity + " de espaço total");

            //user choose if wants to start or turn off the computer
            Console.WriteLine("Se desejar ligar o computador digite: 'ligando', se quiser que ele fique desligado, digite 'desligando'");
            var checkResponse = Console.ReadLine();

            if (checkResponse == "ligando")
            {
                var statusResponse = "Ligando";
            }
            else
            {
                var statusResponse = "Desligando";
            }



            obj.changeStatusPc(statusResponse);
        }
    }
}