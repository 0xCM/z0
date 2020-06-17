//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Memories;

    partial class gbits
    {
        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), SetBit, Closures(AllNumeric)]
        public static T setbit<T>(T src, int pos, bit value)            
            where T : unmanaged
                => value ? enable(src, pos) : disable(src, pos);        
                
        /// <summary>
        /// Calculates z := (src & ~(1 << pos)) | (value << pos) with the intent of enabling/disabling a bit without branching
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        /// <remarks>See https://stackoverflow.com/questions/17803889/set-or-reset-a-given-bit-without-branching</remarks>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T setnb<T>(T src, byte pos, bit value)
            where T : unmanaged
        {
            var x = gmath.negate(gmath.sll(one<T>(), pos));            
            var y = convert<uint,T>((uint)value << pos);
            var z = gmath.and(src, x);
            return gmath.and(z, y);
        }
    }
}