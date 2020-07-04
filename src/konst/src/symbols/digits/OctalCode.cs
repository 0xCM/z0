//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using S = OctalSym;

    public enum OctalCode : byte
    {
        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o0 = (byte)S.o0,

        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o1 = (byte)S.o1,
        
        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o2 = (byte)S.o2,
        
        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o3 = (byte)S.o3,

        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o4 = (byte)S.o4,

        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o5 = (byte)S.o5,

        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o6 = (byte)S.o6,

        /// <summary>
        /// Specifies the asci code for the eponymous hex digit
        /// </summary>
        o7 = (byte)S.o7,

       /// <summary>
        /// The first declared code
        /// </summary>
        First = o0,

        /// <summary>
        /// The last declared code
        /// </summary>
        Last = o7,

        /// <summary>
        /// The code declaration count
        /// </summary>
        Count = Last - First + 1                 
   }
}