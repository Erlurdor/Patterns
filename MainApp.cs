﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    class MainApp
    {
        private int IDCounter = 0;

        // освещение
        private List<Lighting> Lightings = new List<Lighting>();

        public void AddLight(Lighting Lighting)
        {
            Lighting.SetID(IDCounter++);
            Lightings.Add(Lighting);
        }

        public void PowerSwitchLightings(bool value)
        {
            foreach (var item in Lightings)
            {
                item.PowerSwitch(true);
            }
        }

        public void ChangeBrightness(int value)
        {
            foreach (var item in Lightings)
            {
                item.ChangeBrightness(value);
            }            
        }

        public void PowerSwitch(Lighting lamp, bool value)
        {
            lamp.PowerSwitch(value);
        }

        public void ChangeBrightness(Lighting lamp, int value)
        {
            lamp.ChangeBrightness(value);
        }


        // чайники
        private List<Kettle> Kettles = new List<Kettle>();

        public void AddKettle(Kettle kettle)
        {
            kettle.SetID(IDCounter++);
            Kettles.Add(kettle);
        }

        public void PowerSwitchKettles(bool value)
        {
            foreach (var item in Kettles)
            {
                item.PowerSwitch(true);
            }
        }

        public void SetTemperature(int value)
        {
            foreach (var item in Kettles)
            {
                item.SetTemperature(value);
            }
        }

        public void PowerSwitch(Kettle kettle, bool value)
        {
            kettle.PowerSwitch(value);
        }

        public void SetTemperature(Kettle kettle, int value)
        {
            kettle.SetTemperature(value);
        }
    }
}