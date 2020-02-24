//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    public interface IBaseHexFormatter
    {
        string Format(object src, string config = null);
    }
    
    public interface IBaseHexFormatter<T> : IBaseHexFormatter
        where T : struct
    {
        string Format(T src, string config = null);

        string IBaseHexFormatter.Format(object src, string config)
            => Format((T)src,config);        
    }

    interface IBaseHexFormatter<F,T> : IBaseHexFormatter<T>
        where F : struct, IBaseHexFormatter<F,T>
        where T : struct
    {
        HexFormatRelay<T> Relay {get;}
    }

    interface IHexFormatRelay : IBaseHexFormatter
    {
        string Format<T>(T src, string config = null);

        [MethodImpl(Inline)]
        string IBaseHexFormatter.Format(object src, string config)
            => Format(src,config);
    }

    readonly struct HexFormatRelay : IHexFormatRelay
    {
        readonly IBaseHexFormatter Formatter;

        [MethodImpl(Inline)]
        public static HexFormatRelay<T> RelayTo<T>(IBaseHexFormatter formatter)
            where T : struct
                => HexFormatRelay<T>.Create(formatter);

        [MethodImpl(Inline)]
        HexFormatRelay(IBaseHexFormatter formatter)
            => this.Formatter = formatter;

        [MethodImpl(Inline)]
        public string Format<T>(T src, string config = null)
            => Formatter.Format(src,config);        
    }

    readonly struct HexFormatRelay<T> : IBaseHexFormatter<T>
        where T : struct
    {
        public static HexFormatRelay<T> Create(IBaseHexFormatter formatter)
            => new HexFormatRelay<T>(formatter);
        
        readonly IBaseHexFormatter Formatter; 

        [MethodImpl(Inline)]
        HexFormatRelay(IBaseHexFormatter formatter)
            => this.Formatter = formatter;

        [MethodImpl(Inline)]
        public string Format(T src, string config = null)
            => Formatter.Format(src,config);        
    }

    static class BaseHexFormatters
    {
        [MethodImpl(Inline)]
        public static IBaseHexFormatter<T> Create<T>()
            where T : struct
                => relay_u<T>();

        [MethodImpl(Inline)]
        static F GetFormatter<F,T>()
            where F : struct, IBaseHexFormatter<F,T>
            where T : struct
                => formatter_u<F,T>();

        [MethodImpl(Inline)]
        static HexFormatRelay<T> relay_u<T>()
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generalize<byte,T>(GetFormatter<HexFormatter8u,byte>().Relay);
            else if(typeof(T) == typeof(ushort))
                return generalize<ushort,T>(GetFormatter<HexFormatter16u,ushort>().Relay);
            else if(typeof(T) == typeof(uint))
                return generalize<uint,T>(GetFormatter<HexFormatter32u,uint>().Relay);
            else if(typeof(T) == typeof(ulong))
                return generalize<ulong,T>(GetFormatter<HexFormatter64u,ulong>().Relay);
            else
                return relay_i<T>();
        }                

        [MethodImpl(Inline)]
        static HexFormatRelay<T> relay_i<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generalize<sbyte,T>(GetFormatter<HexFormatter8i,sbyte>().Relay);
            else if(typeof(T) == typeof(short))
                return generalize<short,T>(GetFormatter<HexFormatter16i,short>().Relay);
            else if(typeof(T) == typeof(int))
                return generalize<int,T>(GetFormatter<HexFormatter32i,int>().Relay);
            else if(typeof(T) == typeof(long))
                return generalize<long,T>(GetFormatter<HexFormatter64i,long>().Relay);
            else
                return relay_f<T>();
        }                

        [MethodImpl(Inline)]
        static HexFormatRelay<T> relay_f<T>()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generalize<float,T>(GetFormatter<HexFormatter32f,float>().Relay);
            else if(typeof(T) == typeof(double))
                return generalize<double,T>(GetFormatter<HexFormatter64f,double>().Relay);
            else
                throw unsupported<T>();
        }                

        [MethodImpl(Inline)]
        static F formatter_u<F,T>()
            where F : struct, IBaseHexFormatter<F,T>
            where T : struct
        {
            if(typeof(F) == typeof(HexFormatter8u))
                return generalize<HexFormatter8u,F>(HexFormatter8u.TheOnly);
            else if(typeof(F) == typeof(HexFormatter16u))
                return generalize<HexFormatter16u,F>(HexFormatter16u.TheOnly);
            else if(typeof(F) == typeof(HexFormatter32u))
                return generalize<HexFormatter32u,F>(HexFormatter32u.TheOnly);
            else if(typeof(F) == typeof(HexFormatter64u))
                return generalize<HexFormatter64u,F>(HexFormatter64u.TheOnly);
            else
                return formatter_i<F,T>();
        }

        [MethodImpl(Inline)]
        static F formatter_i<F,T>()
            where F : struct, IBaseHexFormatter<F,T>
            where T : struct
        {
            if(typeof(F) == typeof(HexFormatter8i))
                return generalize<HexFormatter8i,F>(HexFormatter8i.TheOnly);
            else if(typeof(F) == typeof(HexFormatter16i))
                return generalize<HexFormatter16i,F>(HexFormatter16i.TheOnly);
            else if(typeof(F) == typeof(HexFormatter32i))
                return generalize<HexFormatter32i,F>(HexFormatter32i.TheOnly);
            else if(typeof(F) == typeof(HexFormatter64i))
                return generalize<HexFormatter64i,F>(HexFormatter64i.TheOnly);
            else
                return formatter_f<F,T>();
        }

        [MethodImpl(Inline)]
        static F formatter_f<F,T>()
            where F : struct, IBaseHexFormatter<F,T>
            where T : struct
        {
            if(typeof(F) == typeof(HexFormatter32f))
                return generalize<HexFormatter32f,F>(HexFormatter32f.TheOnly);
            else if(typeof(F) == typeof(HexFormatter64f))
                return generalize<HexFormatter64f,F>(HexFormatter64f.TheOnly);
            else
                throw unsupported<F>();
        }

        readonly struct HexFormatter8i : IBaseHexFormatter<HexFormatter8i,sbyte>
        {
            public static HexFormatter8i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(sbyte src, string format = null)
                => src.ToString(format ?? string.Empty);
            
            public HexFormatRelay<sbyte> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<sbyte>(this);}
        }

        readonly struct HexFormatter8u : IBaseHexFormatter<HexFormatter8u,byte>
        {
            public static HexFormatter8u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(byte src, string format = null)
                => src.ToString(format ?? string.Empty);

            public HexFormatRelay<byte> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<byte>(this);}
        }

        readonly struct HexFormatter16i : IBaseHexFormatter<HexFormatter16i,short>
        {
            public static HexFormatter16i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(short src, string format = null)
                => src.ToString(format ?? string.Empty);

            public HexFormatRelay<short> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<short>(this);}
        }

        readonly struct HexFormatter16u : IBaseHexFormatter<HexFormatter16u,ushort>
        {
            public static HexFormatter16u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(ushort src, string format = null)
                => src.ToString(format ?? string.Empty);

            public HexFormatRelay<ushort> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<ushort>(this);}
        }

        readonly struct HexFormatter32i : IBaseHexFormatter<HexFormatter32i,int>
        {
            public static HexFormatter32i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(int src, string format = null)
                => src.ToString(format ?? string.Empty);

            public HexFormatRelay<int> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<int>(this);}
        }

        readonly struct HexFormatter32u : IBaseHexFormatter<HexFormatter32u,uint>
        {
            public static HexFormatter32u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(uint src, string format = null)
                => src.ToString(format ?? string.Empty);

            public HexFormatRelay<uint> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<uint>(this);}
        }

        readonly struct HexFormatter64i : IBaseHexFormatter<HexFormatter64i,long>
        {
            public static HexFormatter64i TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(long src, string format = null)
                => src.ToString(format ?? string.Empty);

            public HexFormatRelay<long> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<long>(this);}
        }

        readonly struct HexFormatter64u : IBaseHexFormatter<HexFormatter64u,ulong>
        {
            public static HexFormatter64u TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(ulong src, string format = null)
                => src.ToString(format ?? string.Empty);

            public HexFormatRelay<ulong> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<ulong>(this);}
        }

        readonly struct HexFormatter32f : IBaseHexFormatter<HexFormatter32f,float>
        {
            public static HexFormatter32f TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(float src, string format = null)
                => BitConvert.ToInt32(src).ToString(format ?? string.Empty);

            public HexFormatRelay<float> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<float>(this);}
        }

        readonly struct HexFormatter64f : IBaseHexFormatter<HexFormatter64f,double>
        {
            public static HexFormatter64f TheOnly = default;

            [MethodImpl(Inline)]
            public string Format(double src, string format = null)
                => BitConvert.ToInt64(src).ToString(format ?? string.Empty);

            public HexFormatRelay<double> Relay { [MethodImpl(Inline)] get => HexFormatRelay.RelayTo<double>(this);}
        }


        [MethodImpl(Inline)]
        static ref readonly F generalize<X,F>(in X src)
            where F : struct
            where X : struct
                => ref Unsafe.As<X,F>(ref Unsafe.AsRef(in src));
        
       [MethodImpl(Inline)]
        static ref readonly HexFormatRelay<T> generalize<S,T>(in HexFormatRelay<S> src)
            where S : struct
            where T : struct
                => ref Unsafe.As<HexFormatRelay<S>,HexFormatRelay<T>>(ref Unsafe.AsRef(in src));
 
    }
}