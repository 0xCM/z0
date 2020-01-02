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
    using static AsIn;

    partial class gmath
    {
        /// <summary>
        /// Computes the material nomimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static T nonimpl<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.nonimpl(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.nonimpl(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.nonimpl(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.nonimpl(uint64(a), uint64(b)));
            else
                throw unsupported<T>();
        }
    }

}