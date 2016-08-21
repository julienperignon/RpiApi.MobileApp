using HelloXamarinWorld.UI;


namespace HelloXamarinWorld.Enums
{
    //[0, 1, 4, 7, 8, 9, 10, 11, 15, 17, 18, 21, 22, 23, 24, 25]
    public enum GpioPin
    {
        [CustomDisplay("None")]
        NONE = -1,
        [CustomDisplay("1")]
        GPIO_1 = 1,
        [CustomDisplay("4")]
        GPIO_4 = 4,
        [CustomDisplay("7")]
        GPIO_7 = 7,
        [CustomDisplay("8")]
        GPIO_8 = 8,
        [CustomDisplay("11")]
        GPIO_11 = 11,
        [CustomDisplay("15")]
        GPIO_15 = 15,
        [CustomDisplay("17")]
        GPIO_17 = 17,
        [CustomDisplay("18")]
        GPIO_18 = 18,
        [CustomDisplay("21")]
        GPIO_21 = 21,
        [CustomDisplay("22")]
        GPIO_22 = 22,
        [CustomDisplay("23")]
        GPIO_23 = 23,
        [CustomDisplay("24")]
        GPIO_24 = 24,
        [CustomDisplay("25")]
        GPIO_25 = 25

    }
}
