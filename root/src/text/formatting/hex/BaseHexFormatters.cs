//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Textual;

    static class BaseHexFormatters
    {
        [MethodImpl(Inline)]
        public static ISystemHexFormatter<T> Create<T>()
            where T : struct
                => formatter_u<T>();

        [MethodImpl(Inline)]
        static ISystemHexFormatter<T> formatter_u<T>()
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generalize<HexFormatter8u,ISystemHexFormatter<T>>(HexFormatter8u.TheOnly);
            else if(typeof(T) == typeof(ushort))
                return generalize<HexFormatter16u,ISystemHexFormatter<T>>(HexFormatter16u.TheOnly);
            else if(typeof(T) == typeof(uint))
                return generalize<HexFormatter32u,ISystemHexFormatter<T>>(HexFormatter32u.TheOnly);
            else if(typeof(T) == typeof(ulong))
                return generalize<HexFormatter64u,ISystemHexFormatter<T>>(HexFormatter64u.TheOnly);
            else
                return formatter_i<T>();
        }

        [MethodImpl(Inline)]
        static ISystemHexFormatter<T> formatter_i<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generalize<HexFormatter8i,ISystemHexFormatter<T>>(HexFormatter8i.TheOnly);
            else if(typeof(T) == typeof(short))
                return generalize<HexFormatter16i,ISystemHexFormatter<T>>(HexFormatter16i.TheOnly);
            else if(typeof(T) == typeof(int))
                return generalize<HexFormatter32i,ISystemHexFormatter<T>>(HexFormatter32i.TheOnly);
            else if(typeof(T) == typeof(long))
                return generalize<HexFormatter64i,ISystemHexFormatter<T>>(HexFormatter64i.TheOnly);
            else
                return formatter_f<T>();
        }

        [MethodImpl(Inline)]
        static ISystemHexFormatter<T> formatter_f<T>()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generalize<HexFormatter32f,ISystemHexFormatter<T>>(HexFormatter32f.TheOnly);
            else if(typeof(T) == typeof(double))
                return generalize<HexFormatter64f,ISystemHexFormatter<T>>(HexFormatter64f.TheOnly);
            else
                throw Unsupported.define<T>();
        }

        readonly struct HexFormatter8i : ISystemHexFormatter<HexFormatter8i,sbyte>
        {
            public static HexFormatter8i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(sbyte src, string format = null)
                => src.ToString(format ?? string.Empty);                        
        }

        readonly struct HexFormatter8u : ISystemHexFormatter<HexFormatter8u,byte>
        {
            public static HexFormatter8u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(byte src, string format = null)
                => src.ToString(format ?? string.Empty);            
        }

        readonly struct HexFormatter16i : ISystemHexFormatter<HexFormatter16i,short>
        {
            public static HexFormatter16i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(short src, string format = null)
                => src.ToString(format ?? string.Empty);
        }

        readonly struct HexFormatter16u : ISystemHexFormatter<HexFormatter16u,ushort>
        {
            public static HexFormatter16u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(ushort src, string format = null)
                => src.ToString(format ?? string.Empty);
        }

        readonly struct HexFormatter32i : ISystemHexFormatter<HexFormatter32i,int>
        {
            public static HexFormatter32i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(int src, string format = null)
                => src.ToString(format ?? string.Empty);
        }

        readonly struct HexFormatter32u : ISystemHexFormatter<HexFormatter32u,uint>
        {
            public static HexFormatter32u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(uint src, string format = null)
                => src.ToString(format ?? string.Empty);
        }

        readonly struct HexFormatter64i : ISystemHexFormatter<HexFormatter64i,long>
        {
            public static HexFormatter64i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(long src, string format = null)
                => src.ToString(format ?? string.Empty);
        }

        readonly struct HexFormatter64u : ISystemHexFormatter<HexFormatter64u,ulong>
        {
            public static HexFormatter64u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(ulong src, string format = null)
                => src.ToString(format ?? string.Empty);
        }

        readonly struct HexFormatter32f : ISystemHexFormatter<HexFormatter32f,float>
        {
            public static HexFormatter32f TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(float src, string format = null)
                => BitConvert.ToInt32(src).ToString(format ?? string.Empty);
        }

        readonly struct HexFormatter64f : ISystemHexFormatter<HexFormatter64f,double>
        {
            public static HexFormatter64f TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(double src, string format = null)
                => BitConvert.ToInt64(src).ToString(format ?? string.Empty);
        }

        [MethodImpl(Inline)]
        static ref readonly F generalize<X,F>(in X src)
            where X : struct
                => ref Unsafe.As<X,F>(ref Unsafe.AsRef(in src));        
    }
}