using System;
using WeatherNet;
using WeatherNet.Clients;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                ClientSettings.ApiKey = "sua chave da api";
                Console.WriteLine("Digite o nome de uma cidade para ver o clima:\n");
                string cidade = Console.ReadLine();
                var result = CurrentWeather.GetByCityName(cidade, "Brazil", "se", "metric");
                if (result.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Clima de: {0}", result.Item.City);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Umidade: {0}%", result.Item.Humidity);
                    Console.WriteLine("Temperatura: {0}°C", result.Item.Temp);
                    Console.WriteLine("Temperatura maxima: {0}°C", result.Item.TempMax);
                    Console.WriteLine("Temperatura minima: {0}°C", result.Item.TempMin);
                    Console.WriteLine("Velocidade dos ventos: {0}km/h", result.Item.WindSpeed);
                    Console.ForegroundColor = ConsoleColor.Red; // Gostei disso de ficar mudando de cor kkk
                    Console.WriteLine("\nPrograma desenvolvido por Mateus, utlizando C#.\n\n");
                    Console.ResetColor();
                } else
                {
                    Console.WriteLine("Essa cidade não existe.");
                }
            }
        }
    }
}
