//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static As;    
    using static Root;
    using static CastInternals;
    
    public static partial class Cast
    {
        [MethodImpl(Inline)]
        static T to_u<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(byte))
                return to<T>(uint8(src));
            else if(typeof(S) == typeof(ushort))
                return to<T>(uint16(src));
            else if(typeof(S) == typeof(uint))
                return to<T>(uint32(src));
            else if(typeof(S) == typeof(ulong))
                return to<T>(uint64(src));
            else
                return to_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return to<T>(int8(src));
            else if(typeof(S) == typeof(short))
                return to<T>(int16(src));
            else if(typeof(S) == typeof(int))
                return to<T>(int32(src));
            else if(typeof(S) == typeof(long))
                return to<T>(int64(src));
            else 
                return to_x<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T to_x<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(float))
                return to<T>(float32(src));
            else if(typeof(S) == typeof(double))
                return to<T>(float64(src));
            else if(typeof(S) == typeof(char))
                return to<T>(character(src));
            else            
                return unhandled<S,T>(src);
        }
    }
}