﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class ElectricVehicle : Vehicle
    {
        private float m_BatteryTimeLeft;
        private float m_MaxBatteryTime;

        public void BatteryCharger(int i_HoursToCharge)
        {
            bool isValid = checkIfValidInput(i_HoursToCharge);

            if (isValid)
            {
                m_BatteryTimeLeft += i_HoursToCharge;
            }

            else
            {
                float maxBatteryPossibleToAdd = m_MaxBatteryTime - m_BatteryTimeLeft;
                throw new ValueOutOfRangeException(maxBatteryPossibleToAdd, 0);
            }
        }

        private bool checkIfValidInput(int i_HoursToCharge)
        {
            bool isValid;
            float newBatteryTime = m_BatteryTimeLeft + i_HoursToCharge;

            isValid = newBatteryTime <= m_MaxBatteryTime;

            return isValid;
        }
    }


}
