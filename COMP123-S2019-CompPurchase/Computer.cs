using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2019_CompPurchase
{
    /// <summary>
    /// ENUM to store computer fields on ProductInfoForm
    /// </summary>
    [Flags]
    enum ComputerField
    {
        PRODUCT_ID = 0,
        CONDITION = 14,
        COST = 1,
        PLATFORM = 16,
        OS = 15,
        MANUFACTURER = 2,
        MODEL = 3,
        MEMORY = 5,
        LCD_SIZE = 7,
        HDD = 17,
        CPU_BRAND = 10,
        CPU_NUMBER = 13,
        GPU_TYPE = 19,
        CPU_TYPE = 11,
        CPU_SPEED = 12,
        WEBCAM = 30
    }
    /// <summary>
    /// This class handle a Computer object
    /// </summary>
    public class Computer
    {
        public int ProductId;
        public string Condition;
        public double Cost;
        public string Plataform;
        public string Os;
        public string Manufacturer;
        public string Model;
        public string Memory;
        public string LcdSize;
        public string Hdd;
        public string CpuBrand;
        public string CpuNumber;
        public string GpuType;
        public string CpuType;
        public string CpuSpeed;
        public string WebCam;
    }
}
