//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    using static As;

    partial class gbits
    {
        /// <summary>
        /// Computes z := (lhs << ldx |  rhs >> rdx) >> ldx
        /// </summary>
        /// <param name="left">The value that is displaced leftwards</param>
        /// <param name="ldx">The leftward displacement</param>
        /// <param name="right">The value that is displaced rightwards</param>
        /// <param name="rdx">The rightward displacement</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>
        /// The way to think about this function is as follows: 
        /// The left value is displaced upwards, shifting in zeros, and is combined
        /// with the right value after it is displaced downwards.
        /// This composite is then displaced downwards the same amount by which the
        /// right value was displaced upwards, removing the zeros that were shifted in.
        /// </remarks>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.UnsignedInts)]
        public static T stitch<T>(T left, int ldx, T right, int rdx)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.stitch(uint8(left), ldx, uint8(right), rdx));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.stitch(uint16(left), ldx, uint16(right), rdx));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.stitch(uint32(left), ldx, uint32(right), rdx));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.stitch(uint64(left), ldx, uint64(right), rdx));
            else            
                throw unsupported<T>();
        }
    }
}