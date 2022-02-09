using System;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

namespace SDKTemplate
{
    // Define the characteristics and other properties of our custom service.
    public class Constants
    {
        // BT_Code: Initializes custom local parameters w/ properties, protection levels as well as common descriptors like User Description. 
        public static readonly GattLocalCharacteristicParameters gattOperandParameters = new GattLocalCharacteristicParameters
        {
            CharacteristicProperties = GattCharacteristicProperties.Write |
                                       GattCharacteristicProperties.WriteWithoutResponse,
            WriteProtectionLevel = GattProtectionLevel.Plain,
            UserDescription = "Operand Characteristic"
        };

        public static readonly GattLocalCharacteristicParameters gattOperatorParameters = new GattLocalCharacteristicParameters
        {
            CharacteristicProperties = GattCharacteristicProperties.Write |
                                       GattCharacteristicProperties.WriteWithoutResponse,
            WriteProtectionLevel = GattProtectionLevel.Plain,
            UserDescription = "Operator Characteristic"
        };

        public static readonly GattLocalCharacteristicParameters gattResultParameters = new GattLocalCharacteristicParameters
        {
            CharacteristicProperties = GattCharacteristicProperties.Read |
                                       GattCharacteristicProperties.Notify,
            WriteProtectionLevel = GattProtectionLevel.Plain,
            UserDescription = "Result Characteristic"
        };

        public static readonly Guid CalcServiceUuid = Guid.Parse("00001101-0000-1000-8000-00805F9B34FB");

        public static readonly Guid Op1CharacteristicUuid = Guid.Parse("00001101-0000-1000-8000-00805F9B34FB");
        public static readonly Guid Op2CharacteristicUuid = Guid.Parse("00001101-0000-1000-8000-00805F9B34FB");
        public static readonly Guid OperatorCharacteristicUuid = Guid.Parse("00001101-0000-1000-8000-00805F9B34FB");
        public static readonly Guid ResultCharacteristicUuid = Guid.Parse("00001101-0000-1000-8000-00805F9B34FB");
    };
}
