using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Továrna.Tridy
{
    internal class Tovarna
    {
        static Dictionary<string, string> TeslaIndustries = new Dictionary<string, string>()
        {
            {"Model 3", "data:image/jpeg;base64,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" },
            {"Model S", "https://i.pinimg.com/originals/7e/2c/ed/7e2cedfda4fb62b4657f7d386a20a685.jpg" },
            {"Model X", "https://i.quotev.com/tinohuzkngpa.jpg" },
            {"Model Y", "https://imgix.ranker.com/user_node_img/50103/1002048856/original/the-littlest-plow-photo-u1?auto=format&q=60&fit=crop&fm=pjpg&dpr=2&w=375" },
            {"Cybertruck", "https://assets1.cbsnewsstatic.com/hub/i/r/2011/04/21/116ba444-a643-11e2-a3f0-029118418759/thumbnail/1200x630/881e24d5342415ae0aab78a3b4c8a3a5/brat.jpghttps://i.redd.it/86p0ju71htj31.jpg" }
        };

        public static string Menu()
        {
            Console.WriteLine("Vítejte v továrně Tesla");
            Console.WriteLine("V nabidce máme");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Model S");
            Console.WriteLine("Model 3");
            Console.WriteLine("Model X");
            Console.WriteLine("Model Y");
            Console.WriteLine("Cybertruck");

            Console.WriteLine("------------------------------");

            Console.WriteLine("1.Chci zobrazit poslední vytvořené auto");
            Console.WriteLine("2.Chci vytvořit nové auto");

            string input = Console.ReadLine();
            return input;
        }

        public static Auto VytvorAuto()
        {
            Console.Clear();

            Auto vyrabeneAuto = new Auto();

            while (true)
            {
                Console.WriteLine("Zadej model : (zadejte přesný název)");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Model S");
                Console.WriteLine("Model 3");
                Console.WriteLine("Model X");
                Console.WriteLine("Model Y");
                Console.WriteLine("Cybertruck");

                vyrabeneAuto.Model = Console.ReadLine();
                if (TeslaIndustries.ContainsKey(vyrabeneAuto.Model))
                {
                    break;
                }
                Console.WriteLine("Napsal jsi to špatně. Zkus to znovu");
            }


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Zadej počet sedadel");
                Console.ForegroundColor = ConsoleColor.White;
                vyrabeneAuto.PocetSedadel = Convert.ToInt32(Console.ReadLine());
                if (vyrabeneAuto.PocetSedadel >= 2 && vyrabeneAuto.PocetSedadel <= 16)
                {
                    break;
                }
                Console.WriteLine("Napsal jsi až moc velký počet sedadel. Zkus to znovu");
            }

            while (true)
            {

                Console.WriteLine("Zadej druh pohonu");
                Console.WriteLine("Elektrický/Hybridní");
                vyrabeneAuto.DruhPohonu = Console.ReadLine();
                if (vyrabeneAuto.DruhPohonu == "Elektrický" || vyrabeneAuto.DruhPohonu == "Hybridní")
                {
                    break;
                }
                Console.WriteLine("Napsal jsi to špatně. Zkus to znovu");

            }

            Console.WriteLine("Zadej Cenu:  (des. čísla = čárka");
            vyrabeneAuto.Cena = Convert.ToInt32(Console.ReadLine());

            vyrabeneAuto.Obrazek = TeslaIndustries[vyrabeneAuto.Model];

            return vyrabeneAuto;
        }


        public static void VytvorStranku(Auto vyrobeneAuto)
        {
            string html = $@"
            <html>
            <body>
            <h1>Továrna na auta</h1>
            <h2 style='color:blue;'>{vyrobeneAuto.Znacka}</h2>
            <h2>{vyrobeneAuto.Model}</h2>
            <h2>Počet sedaček: {vyrobeneAuto.PocetSedadel}</h2>
            <h2>Druh pohonu: {vyrobeneAuto.DruhPohonu}</h2>
            <img  src='{vyrobeneAuto.Obrazek}'>
            <h3>Rok výroby: {vyrobeneAuto.rokvyroby}</h3>
            <hr>
            <div>
            Cena: <h4 style=' color: orange;'>{vyrobeneAuto.Cena}  </h4>
            </div>
            </body>
            </html>";
            File.WriteAllText("index.html", html);
        }



        public static void ZobrazStranku(string adresaSouboru)
        {
            var process = new System.Diagnostics.ProcessStartInfo();
            process.UseShellExecute = true;
            process.FileName = adresaSouboru;
            System.Diagnostics.Process.Start(process);
        }
    }
}
