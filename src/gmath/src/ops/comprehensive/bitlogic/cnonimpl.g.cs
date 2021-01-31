//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Numeric;

    using BL = ScalarBitLogic;

    partial class gmath
    {
        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for integral values a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl, Closures(Integers)]
        public static T cnonimpl<T>(T a, T b)
            where T : unmanaged
                => cnonimpl_u(a,b);

        [MethodImpl(Inline)]
        static T cnonimpl_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return force<T>(BL.cnonimpl(force<T,uint>(a), force<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return force<T>(BL.cnonimpl(force<T,uint>(a), force<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(BL.cnonimpl(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(BL.cnonimpl(uint64(a), uint64(b)));
            else
                return cnonimpl_i(a,b);
        }

        [MethodImpl(Inline)]
        static T cnonimpl_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(BL.cnonimpl(force<T,int>(a), force<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return force<T>(BL.cnonimpl(force<T,int>(a), force<T,int>(b)));
            else if(typeof(T) == typeof(int))
                return generic<T>(BL.cnonimpl(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                return generic<T>(BL.cnonimpl(int64(a), int64(b)));
            else
                throw Unsupported.define<T>();
        }
    }
}