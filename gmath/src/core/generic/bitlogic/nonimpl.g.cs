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
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static T nonimpl<T>(T a, T b)
            where T : unmanaged
                => nonimpl_u(a,b);

        [MethodImpl(Inline)]
        static T nonimpl_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.nonimpl(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.nonimpl(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.nonimpl(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.nonimpl(uint64(a), uint64(b)));
            else
                return nonimpl_i(a,b);
        }

        [MethodImpl(Inline)]
        static T nonimpl_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.nonimpl(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.nonimpl(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.nonimpl(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.nonimpl(int64(a), int64(b)));
            else
                throw unsupported<T>();
        }
    }
}