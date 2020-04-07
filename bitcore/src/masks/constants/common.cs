//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class BitMasks
    {            
        /// <summary>
        /// [10000000]
        /// </summary>
        public const byte SignMask8 = Pow2.T07;

        /// <summary>
        /// [10000000 00000000]
        /// </summary>
        public const ushort SignMask16 = Pow2.T15;
        
        /// <summary>
        /// [10000000 00000000 00000000 00000000]
        /// </summary>
        public const uint SignMask32 = Pow2.T31;

        /// <summary>
        /// [10000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000]
        /// </summary>
        public const ulong SignMask64 = Pow2.T63;

        public const byte Ones8u = byte.MaxValue;

        public const sbyte Ones8i = -1;

        public const ushort Ones16u = ushort.MaxValue;

        public const short Ones16i = -1;

        public const uint Ones32u = uint.MaxValue;

        public const int Ones32i = -1;

        public const ulong Ones64u = ulong.MaxValue;

        public const long Ones64i = -1;

    }

}