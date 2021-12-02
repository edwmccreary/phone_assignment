using System;

namespace phone_assignment
{

    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) 
            {
                SetBrand("Galaxy");
            }
        public string Ring() 
        {
            return $"... {GetRingTone()} ...";
        }
                    
        public string Unlock() 
        {
            return $"{GetBrand()} {GetVersion()} unlocked with fingerprint scanner";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"#######################\n{GetBrand()} {GetVersion()}\nBattery Percentage: {GetBatteryPercentage()}\nCarrier: {GetCarrier()}\nRing Tone: {GetRingTone()}\n#######################");
        }
    }

}