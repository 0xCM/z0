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
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static T inc<T>(T a)
            where T : unmanaged
                => inc_u(a);

        [MethodImpl(Inline)]
        static T inc_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.inc(convert<T,uint>(a)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.inc(convert<T,uint>(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.inc(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.inc(uint64(a)));
            else
                return inc_i(a);
        }

        [MethodImpl(Inline)]
        static T inc_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.inc(convert<T,int>(a)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.inc(convert<T,int>(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.inc(int32(a)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.inc(int64(a)));
            else
                return gfp.inc(a);
        }

    }
}