//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct NumericCast
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(object src)
            where T : unmanaged
                => force_u<T>(src);

        [MethodImpl(Inline)]
        static T force_u<T>(object src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return force<T>(unbox<byte>(src));
            else if(typeof(T) == typeof(ushort))
                return force<T>(unbox<ushort>(src));
            else if(typeof(T) == typeof(uint))
                return force<T>(unbox<uint>(src));
            else if(typeof(T) == typeof(ulong))
                return force<T>(unbox<ulong>(src));
            else
                return force_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T force_i<T>(object src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(unbox<sbyte>(src));
            else if(typeof(T) == typeof(short))
                return force<T>(unbox<short>(src));
            else if(typeof(T) == typeof(int))
                return force<T>(unbox<int>(src));
            else if(typeof(T) == typeof(long))
                return force<T>(unbox<long>(src));
            else
                return force_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T force_x<T>(object src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return force<T>(unbox<float>(src));
            else if(typeof(T) == typeof(double))
                return force<T>(unbox<double>(src));
            else
                throw no<T>();
        }
    }
}