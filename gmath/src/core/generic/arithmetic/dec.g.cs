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

    partial class gmath
    {
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T dec<T>(T a)
            where T : unmanaged
                => dec_u(a);

        [MethodImpl(Inline)]
        static T dec_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.dec(convert<T,uint>(a)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.dec(convert<T,uint>(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.dec(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.dec(uint64(a)));
            else
                return dec_i(a);
        }

        [MethodImpl(Inline)]
        static T dec_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.dec(convert<T,int>(a)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.dec(convert<T,int>(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.dec(int32(a)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.dec(int64(a)));
            else
                return gfp.dec(a);
        }

    }
}