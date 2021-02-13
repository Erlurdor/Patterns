using System;

namespace Patt3_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TempValue = 100;
            

            // главное приложение
            MainApp app = new MainApp();

            /*
             * Прокси, Делегирование
             */
                
            /*
            // освещение
            Lighting lamp = new Chandelier("Lamp1");
            Lighting lamp2 = new XiaomiLamp("Lamp2");

            app.AddLight(lamp);
            app.AddLight(lamp2);

            // тест работы освещения
            app.PowerSwitchLightings(true);
            app.ChangeBrightness(TempValue);

            app.PowerSwitch(lamp, false);
            app.ChangeBrightness(lamp, TempValue);
            

            // чайники
            Kettle noSmartKettle2 = new NoSmartKettle("noSmartKetle");
            Kettle xiaomiKettle2 = new XiaomiKettle("xiaomiKettle");

            Kettle noSmartKettle = new NoSmartKettle("noSmartKettle");
            Kettle xiaomiKettle = new XiaomiKettle("xiaomiKettle");

            Kettle proxyNoSmartKettle = new ProxyKettle(noSmartKettle);
            Kettle proxyXiaomiKettle = new ProxyKettle(xiaomiKettle);


            app.AddKettle(noSmartKettle2);
            app.AddKettle(xiaomiKettle2);
            app.AddKettle(proxyNoSmartKettle);
            app.AddKettle(proxyXiaomiKettle);

            // тест работы
            app.PowerSwitchKettles(true);
            app.SetTemperature(TempValue);

            app.PowerSwitch(proxyXiaomiKettle, false);
            app.SetTemperature(proxyXiaomiKettle, TempValue - 4);
            app.SetTemperature(proxyNoSmartKettle, TempValue - 4);
            */


            /*
             * Адаптер
             */
            /*
            // создаем оригинальный чайник
            Kettle xiaomiKettle = new XiaomiKettle("XiaomiKettle");
            app.AddKettle(xiaomiKettle);

            // создаем похожее на чайник ()
            WaterHeater waterHeater = new WaterHeater();
            Kettle nowKettle = new WaterHeaterToKettleAdapter("nowKettle", waterHeater);
            app.AddKettle(nowKettle);

            // проверка данных
            Console.WriteLine(nowKettle.GetTemperature());
            Console.WriteLine(nowKettle.GetPower());

            // тест работы
            app.PowerSwitchKettles(true);
            app.SetTemperature(TempValue);

            // проверка данных
            Console.WriteLine(nowKettle.GetTemperature());
            Console.WriteLine(nowKettle.GetPower());
            */


            /*
             * 
             */




            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}