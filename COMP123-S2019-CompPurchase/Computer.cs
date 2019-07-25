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
    enum computerField
    {
        PRODUCT_ID,
        CONDITION,
        COST,
        PLATFORM,
        OS,
        MANUFACTURER,
        MODEL,
        MEMORY,
        LCD_SIZE,
        HDD,
        CPU_BRAND,
        CPU_NUMBER,
        GPU_TYPE,
        CPU_TYPE,
        CPU_SPEED,
        WEBCAM,
        NUMBER_OF_ITEMS
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
