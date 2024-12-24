using System;

namespace WaterMeterApp
{
    public class WaterMeter : ICloneable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public DateTime LastVerificationDate { get; set; }
        public bool IsForHotWater { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
