//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gmath
    {
        /// <summary>
        /// Computes the material implication c := a | ~b for unsigned integers a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static T impl<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.impl(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.impl(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.impl(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.impl(uint64(a), uint64(b)));
            else
                throw unsupported<T>();
        }
    }

}