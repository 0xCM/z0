//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;    

    partial class Bits
    {                 
        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive index range
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="min">The first bit selected</param>
        /// <param name="max">The last bit selected</param>
        [MethodImpl(Inline)]
        public static byte range(byte a, uint min, uint max)
            => (byte)range((uint)a, min, max);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive index range
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="min">The first bit selected</param>
        /// <param name="max">The last bit selected</param>
        [MethodImpl(Inline)]
        public static ushort range(ushort a, uint min, uint max)
            => (ushort)range((uint)a, min, max);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive index range
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="min">The first bit selected</param>
        /// <param name="max">The last bit selected</param>
        [MethodImpl(Inline)]
        public static uint range(uint a, uint min, uint max)
            => Bmi1.BitFieldExtract(a, (byte)min, (byte)(max - min + 1));

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive index range
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="min">The first bit selected</param>
        /// <param name="max">The last bit selected</param>
        [MethodImpl(Inline)]
        public static ulong range(ulong a, uint min, uint max)
            => Bmi1.X64.BitFieldExtract(a, (byte)min, (byte)(max - min + 1));




    }

}