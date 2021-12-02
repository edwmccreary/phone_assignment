
namespace phone_assignment
{
    public abstract class Phone 
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;
        private string _brand;
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        // abstract method. This method will be implemented by the subclasses
        public abstract void DisplayInfo();
        // public getters and setters removed for brevity. Please implement them yourself
        public void SetBrand(string brand){
            _brand = brand;
        }
        public string GetBrand(){
            return _brand;
        }

        public string GetVersion(){
            return _versionNumber;
        }
        public int GetBatteryPercentage(){
            return _batteryPercentage;
        }
        public string GetCarrier(){
            return _carrier;
        }
        public string GetRingTone(){
            return _ringTone;
        }
    }
}
