using System;

namespace phone_assignment
{

    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) 
            {
                SetBrand("Nokia");
            }
        public string Ring() 
        {
            return $"... {GetRingTone()} ...";
        }
        public string Unlock() 
        {
            return $"{GetBrand()} {GetVersion()} unlocked with passcode";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$\n{GetBrand()} {GetVersion()}\nBattery Percentage: {GetBatteryPercentage()}\nCarrier: {GetCarrier()}\nRing Tone: {GetRingTone()}\n$$$$$$$$$$$$$$$$$$$$$");
        }
    }

}