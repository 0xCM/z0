//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using S = BinarySym;

    public enum BinaryDigitCode : byte
    {
        /// <summary>
        /// The binary digit with no code
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies the asci code for the eponymous binary digit
        /// </summary>
        b0 = (byte)S.b0,

        /// <summary>
        /// Specifies the asci code for the eponymous binary digit
        /// </summary>
        b1 = (byte)S.b1,

        /// <summary>
        /// The first declared code
        /// </summary>
        First = b0,

        /// <summary>
        /// The last declared code
        /// </summary>
        Last = b1,

        /// <summary>
        /// The code declaration count
        /// </summary>
        Count = Last - First + 1         
   }
}