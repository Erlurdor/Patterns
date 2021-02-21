using System;

namespace Patt3_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TempValue = 100;


            // главное приложение
            MainApp app = MainApp.GetMainApp();


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
             * Декоратор
             */
            /*
            Organizer organizer = new XiaomiOrganizer("Default organizer");
            MorningOrganizer morningOrganizer = new MorningOrganizer("Morning", organizer);
            EveningOrganizer eveningOrganizer = new EveningOrganizer("Evening", morningOrganizer);

            Console.WriteLine(morningOrganizer.getMessage());
            Console.WriteLine(eveningOrganizer.getMessage());
            */


            /*
             * Мост
             */
            /*
            RemoteController remoteController1 = new RemoteController("RC for XiaomiTV", new XiaomiTV("XiaomiTV"));
            RemoteController remoteController2 = new RemoteController("RC for SonyTV", new SonyTV("SonyTV"));

            remoteController1.Info();
            remoteController2.Info();

            remoteController1.NextChannel();
            remoteController1.NextChannel();
            remoteController1.NextChannel();

            remoteController2.NextChannel();
            remoteController2.NextChannel();
            remoteController2.PreviousChannel();
            remoteController2.NextChannel();
            */



            /*
             * Фасад
             */
            /*
            Kettle kettle = new XiaomiKettle("Xiaomi Kettle");
            Lighting lamp = new XiaomiLamp("Xiaomi Lamp");
            Organizer organizer = new XiaomiOrganizer("Xiaomi Organizer");
            RemoteController remoteController = new RemoteController("RC for Xiaomi TV", new XiaomiTV("XiaomiTV"));

            WelcomeHomeFacade welcomeHomeFacade = new WelcomeHomeFacade(kettle, lamp, organizer, remoteController);

            welcomeHomeFacade.GotHome();
            welcomeHomeFacade.LeftHome();
            */



            /*
             * Одиночка
             */
            /*
            MainApp app2 = MainApp.GetMainApp();  
            Console.WriteLine(ReferenceEquals(app, app2));
            */


            /*
             * Простая фабрика
             */
            /*
            KettleSimpleFactory kettleSimpleFactory = new KettleSimpleFactory();
            Kettle kettle1 = kettleSimpleFactory.createKettle("installable", "kettle1");
            Console.WriteLine(kettle1.GetName());
            Console.WriteLine(kettle1.GetType());
            Console.WriteLine("\n\n");

            Kettle kettle2 = kettleSimpleFactory.createKettle("noinstallable", "kettle2");
            Console.WriteLine(kettle2.GetName());
            Console.WriteLine(kettle2.GetType());
            Console.WriteLine("\n\n");

            Kettle kettle3 = kettleSimpleFactory.createKettle("111installable", "kettle3");
            Console.WriteLine(kettle3.GetName());
            Console.WriteLine(kettle3.GetType());
            Console.WriteLine("\n\n");
            */



            /*
             * Абстрактная Фабрика
             */
            /*
            DeviceAbstractFactory deviceAbstractFactory = new XiaomiDeviceAbstractFactory();
            Kettle kettle1 = deviceAbstractFactory.createKettle("Kettle1");
            Lighting lighting1 = deviceAbstractFactory.createLighting("Lamp1");

            //app.AddKettle(kettle1);
            //app.AddLight(lighting1);

            Console.WriteLine(kettle1.GetName());
            Console.WriteLine(kettle1.GetType());

            Console.WriteLine(lighting1.GetName());
            Console.WriteLine(lighting1.GetType());

            //app.PowerSwitch(kettle1, false);
            //app.ChangeBrightness(lighting1, 100);


            Console.WriteLine("\n\n");
            DeviceAbstractFactory deviceAbstractFactory2 = new NoSmartDeviceAbstractFactory();
            Kettle kettle2 = deviceAbstractFactory2.createKettle("Kettle2");
            Lighting lighting2 = deviceAbstractFactory2.createLighting("Lamp2");

            //app.AddKettle(kettle1);
            //app.AddLight(lighting1);

            Console.WriteLine(kettle2.GetName());
            Console.WriteLine(kettle2.GetType());

            Console.WriteLine(lighting2.GetName());
            Console.WriteLine(lighting2.GetType());
            */


            /*
             * Наблюдатель
             */
            /*
            EventListener logging = new LoggingEventListener();
            EventListener dating = new DataLoggingEventListener();

            app.eventManager.Subscribe(logging);
            app.eventManager.Subscribe(dating);


            Kettle kettle1 = new XiaomiKettle("kettle1");
            Lighting lighting1 = new XiaomiLamp("lighting1");

            app.AddKettle(kettle1);

            app.eventManager.Unsubscribe(dating);
            app.AddLight(lighting1);
            */


            /*
             * Состояние
             */
            Microwave microwave = new DefaultMicrowave("Microwave");

            Console.WriteLine("Microwave options:\n");
            Console.WriteLine("1 - On");
            Console.WriteLine("2 - Off");
            Console.WriteLine("3 - Reheat food onf 5 sec\n");

            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        microwave.On();
                        break;

                    case ConsoleKey.D2:
                        microwave.Off();
                        break;

                    case ConsoleKey.D3:
                        microwave.ReheatFood(5);
                        break;
                }
            }
            while (key != ConsoleKey.Escape);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}