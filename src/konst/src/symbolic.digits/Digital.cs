//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    [ApiHost(ApiNames.SymbolicDigits, true)]
    public readonly partial struct Digital
    {
        /// <summary>
        /// Defines the asci character codes for uppercase hex digits 1,2, ..., 9, A, ..., F
        /// </summary>
        public static ReadOnlySpan<byte> UpperHexDigits
            => new byte[]{48,49,50,51,52,53,54,55,56,57,65,66,67,68,69,70};

        /// <summary>
        /// Defines the asci character codes for uppercase hex digits 1,2, ..., 9, a, ..., f
        /// </summary>
        public static ReadOnlySpan<byte> LowerHexDigits
            => new byte[]{48,49,50,51,52,53,54,55,56,57,97,98,99,100,101,102};

        /// <summary>
        /// Extracts the four lo digits
        /// </summary>
        /// <param name="src">The encoded digit source</param>
        /// <param name="d3">The target for the fourth and most-significant digit</param>
        /// <param name="d2">The target for the third digit</param>
        /// <param name="d1">The target for the second digit</param>
        /// <param name="d0">The target for the first and least-significant digit</param>
        [MethodImpl(Inline), Op]
        public static void lo(ulong src, out byte d3, out byte d2, out byte d1, out byte d0)
        {
            d3 = (byte)digit(src,3);
            d2 = (byte)digit(src,2);
            d1 = (byte)digit(src,1);
            d0 = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the four hi digits
        /// </summary>
        /// <param name="src">The encoded digit source</param>
        /// <param name="d7">The target for the eighth and most-significant digit</param>
        /// <param name="d6"></param>
        /// <param name="d5"></param>
        /// <param name="d4"></param>
        [MethodImpl(Inline), Op]
        public static void hi(ulong src, out byte d7, out byte d6, out byte d5, out byte d4)
        {
            d7 = (byte)digit(src,7);
            d6 = (byte)digit(src,6);
            d5 = (byte)digit(src,5);
            d4 = (byte)digit(src,4);
        }
    }
}