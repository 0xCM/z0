//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    

    partial class gmath
    {
        [MethodImpl(Inline), Xnor, NumericClosures(NumericKind.Integers)]
        public static T xnor<T>(T a, T b)
            where T : unmanaged
                => xnor_u(a,b);

        [MethodImpl(Inline)]
        static T xnor_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.xnor(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.xnor(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xnor(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xnor(uint64(a), uint64(b)));
            else
                return xnor_i(a,b);
        }

        [MethodImpl(Inline)]
        static T xnor_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.xnor(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.xnor(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.xnor(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.xnor(int64(a), int64(b)));
            else
                throw unsupported<T>();
        }
    }
}