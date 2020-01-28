//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    partial class gbits
    {
        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static T set<T>(T src, int pos, bit value)            
            where T : unmanaged
        {
            if(value)
                return gbits.enable(src, pos);
            else
                return gbits.disable(src, pos);
        }

        /// <summary>
        /// Sets a bit value in a T-sequence predicated on a linear index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The linear index of the target bit, relative to the sequence head</param>
        /// <typeparam name="T">The sequence type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static void set<T>(in Block256<T> src, int index, bit value)
            where T : unmanaged
        {
            var loc = bitpos<T>(index);
            src[loc.CellIndex] = gbits.set(src[loc.CellIndex], (byte)loc.BitOffset, value);
        }

        /// <summary>
        /// Calculates z := (src & ~(1 << pos)) | (value << pos) with the intent of enabling/disabling a bit without branching
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        /// <remarks>See https://stackoverflow.com/questions/17803889/set-or-reset-a-given-bit-without-branching</remarks>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static T setnb<T>(T src, byte pos, bit value)
            where T : unmanaged
        {
            var x = gmath.negate(gmath.sll(gmath.one<T>(), pos));            
            var y = convert<uint,T>((uint)value << pos);
            var z = gmath.and(src, x);
            return gmath.and(z, y);
        }
    }
}