using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    class WelcomeHomeFacade : Device
    {
        private Kettle kettle;
        private Lighting lighting;
        private Organizer organizer;
        private RemoteController remoteController;

        private int temperatureKettle;
        private int brightnessLighting;
        private int channelRemoteController;

        public WelcomeHomeFacade(string name, Kettle kettle, Lighting lighting, Organizer organizer, RemoteController remoteController) : base(name)
        {
            this.kettle = kettle;
            this.lighting = lighting;
            this.organizer = organizer;
            this.remoteController = remoteController;

            temperatureKettle = 80;
            brightnessLighting = 90;
            channelRemoteController = 4;
        }


        public void SetTtemperatureKettle(int temperatureKettle)
        {
            this.temperatureKettle = temperatureKettle;
        }

        public void SetBrightnessLighting(int brightnessLighting)
        {
            this.brightnessLighting = brightnessLighting;
        }

        public void SetChannelRemoteController(int channelRemoteController)
        {
            this.channelRemoteController = channelRemoteController;
        }

        public void GotHome()
        {
            kettle.PowerSwitch(true);
            kettle.SetTemperature(temperatureKettle);

            lighting.PowerSwitch(true);
            lighting.ChangeBrightness(brightnessLighting);

            organizer.getMessage();

            remoteController.On();
            remoteController.SetChannel(channelRemoteController);
        }

        public void LeftHome()
        {
            kettle.PowerSwitch(false);

            lighting.PowerSwitch(false);

            remoteController.Off();
        }
    }
}