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

    partial class gmath
    {
        [MethodImpl(Inline), Not, Closures(Integers)]
        public static T not<T>(T a)
            where T : unmanaged
                => not_u(a);

        [MethodImpl(Inline)]
        static T not_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(BitLogic.not(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(BitLogic.not(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(BitLogic.not(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(BitLogic.not(uint64(a)));
            else
                return not_i(a);
        }

        [MethodImpl(Inline)]
        static T not_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(BitLogic.not(int8(a)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(BitLogic.not(int16(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(BitLogic.not(int32(a)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(BitLogic.not(int64(a)));
            else
                throw Unsupported.define<T>();
        }
    }
}