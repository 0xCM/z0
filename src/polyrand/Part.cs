//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Polyrand)]

namespace Z0.Parts
{
    public sealed class Polyrand : Part<Polyrand>
    {        
        
    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public static partial class Rng
    {
        
    }

    public static partial class XTend
    {
        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        internal static uint Contract(this uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        internal static ulong Contract(this ulong src, ulong max)
            => math.mulhi(src,max); 
    }

    public static partial class XRng
    {

    }

    public enum EmbeddedRngKind
    {
        /// <summary>
        /// The nothingness of the void
        /// </summary>
        None = 0,

        /// <summary>
        /// A 32-bit PCG generator
        /// </summary>
        Pcg32 = RngKind.Pcg32,

        /// <summary>
        /// A 64-bit PCG generator
        /// </summary>
        Pcg64 = RngKind.Pcg64,

        /// <summary>
        /// A 16-bit WyHash generator
        /// </summary>
        WyHash16 = RngKind.WyHash16,

        /// <summary>
        /// A 64-bit WyHash generator
        /// </summary>
        WyHash64 = RngKind.WyHash64,

        /// <summary>
        /// A 64-bit SplitMix generator
        /// </summary>
        SplitMix64 = RngKind.SplitMix64,

        /// <summary>
        /// An xorshift generator with 128 bits of state
        /// </summary>
        XOrShift128 = RngKind.XOrShift128,

        /// <summary>
        /// An xorshift generator with 256 bits of state
        /// </summary>
        XOrShift256 = RngKind.XOrShift256,

        /// <summary>
        /// An xorshift generator with 1024 bits of state
        /// </summary>
        XOrShift1024 = RngKind.XOrShift1024,
    }


}
