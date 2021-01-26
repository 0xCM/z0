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

    partial class AsNumeric
    {
        [MethodImpl(Inline)]
        public static R presenter<R,S,T>()
            where T : unmanaged
            where R : unmanaged, IAs<R,S,T>
                => presenter_u<R,S,T>();

        [MethodImpl(Inline)]
        public static T present<S,T>(S src)
            where T : unmanaged
                => present_u<S,T>(src);

        [MethodImpl(Inline)]
        public static ref T present<S,T>(ref S src)
            where T : unmanaged
                => ref present_u<S,T>(ref src);

        [MethodImpl(Inline)]
        public static AsI8<S> I8<S>()
            => default(AsI8<S>);

        [MethodImpl(Inline)]
        public static AsU8<S> U8<S>()
            => default(AsU8<S>);

        [MethodImpl(Inline)]
        public static AsI16<S> I16<S>()
            => default(AsI16<S>);

        [MethodImpl(Inline)]
        public static AsU16<S> U16<S>()
            => default(AsU16<S>);

        [MethodImpl(Inline)]
        public static AsI32<S> I32<S>()
            => default(AsI32<S>);

        [MethodImpl(Inline)]
        public static AsU32<S> U32<S>()
            => default(AsU32<S>);

        [MethodImpl(Inline)]
        public static AsI64<S> I64<S>()
            => default(AsI64<S>);

        [MethodImpl(Inline)]
        public static AsU64<S> U64<S>()
            => default(AsU64<S>);

        [MethodImpl(Inline)]
        public static AsF32<S> F32<S>()
            => default(AsF32<S>);

        [MethodImpl(Inline)]
        public static AsF64<S> F64<S>()
            => default(AsF64<S>);

        [MethodImpl(Inline)]
        static ref readonly R generalize<X,R>(in X src)
            where R : unmanaged
                => ref Unsafe.As<X,R>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        static R presenter_u<R,S,T>()
            where T : unmanaged
            where R : unmanaged, IAs<R,S,T>
        {
            if(typeof(T) == typeof(byte))
                return generalize<AsU8<S>,R>(U8<S>());
            else if(typeof(T) == typeof(ushort))
                return generalize<AsU16<S>,R>(U16<S>());
            else if(typeof(T) == typeof(uint))
                return generalize<AsU32<S>,R>(U32<S>());
            else if(typeof(T) == typeof(ulong))
                return generalize<AsU64<S>,R>(U64<S>());
            else
                return presenter_i<R,S,T>();
        }

        [MethodImpl(Inline)]
        static R presenter_i<R,S,T>()
            where T : unmanaged
            where R : unmanaged, IAs<R,S,T>
        {
            if(typeof(T) == typeof(sbyte))
                return generalize<AsI8<S>,R>(I8<S>());
            else if(typeof(T) == typeof(short))
                return generalize<AsI16<S>,R>(I16<S>());
            else if(typeof(T) == typeof(int))
                return generalize<AsI32<S>,R>(I32<S>());
            else if(typeof(T) == typeof(long))
                return generalize<AsI64<S>,R>(I64<S>());
            else
                return presenter_f<R,S,T>();
        }

        [MethodImpl(Inline)]
        static R presenter_f<R,S,T>()
            where T : unmanaged
            where R : unmanaged, IAs<R,S,T>
        {
            if(typeof(T) == typeof(byte))
                return generalize<AsF32<S>,R>(F32<S>());
            else if(typeof(T) == typeof(ushort))
                return generalize<AsF64<S>,R>(F64<S>());
            else
                throw Unsupported.define<S>();
        }

        [MethodImpl(Inline)]
        static T present_u<S,T>(S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(U8<S>().As(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(U16<S>().As(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(U32<S>().As(src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(U64<S>().As(src));
            else
                return present_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T present_i<S,T>(S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(I8<S>().As(src));
            else if(typeof(T) == typeof(short))
                return generic<T>(I16<S>().As(src));
            else if(typeof(T) == typeof(int))
                return generic<T>(I32<S>().As(src));
            else if(typeof(T) == typeof(long))
                return generic<T>(I64<S>().As(src));
            else
                return present_f<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T present_f<S,T>(S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(F32<S>().As(src));
            else if(typeof(T) == typeof(double))
                return generic<T>(F64<S>().As(src));
            else
                throw Unsupported.define<T>();
        }


        [MethodImpl(Inline)]
        static ref T present_u<S,T>(ref S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return ref Unsafe.As<byte,T>(ref U8<S>().As(ref src));
            else if(typeof(T) == typeof(ushort))
                return ref Unsafe.As<ushort,T>(ref U16<S>().As(ref src));
            else if(typeof(T) == typeof(uint))
                return ref Unsafe.As<uint,T>(ref U32<S>().As(ref src));
            else if(typeof(T) == typeof(ulong))
                return ref Unsafe.As<ulong,T>(ref U64<S>().As(ref src));
            else
                return ref present_i<S,T>(ref src);
        }

        [MethodImpl(Inline)]
        static ref T present_i<S,T>(ref S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ref Unsafe.As<sbyte,T>(ref I8<S>().As(ref src));
            else if(typeof(T) == typeof(short))
                return ref Unsafe.As<short,T>(ref I16<S>().As(ref src));
            else if(typeof(T) == typeof(int))
                return ref Unsafe.As<int,T>(ref I32<S>().As(ref src));
            else if(typeof(T) == typeof(long))
                return ref Unsafe.As<long,T>(ref I64<S>().As(ref src));
            else
                return ref present_f<S,T>(ref src);
        }

        [MethodImpl(Inline)]
        static ref T present_f<S,T>(ref S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return ref Unsafe.As<float,T>(ref F32<S>().As(ref src));
            else if(typeof(T) == typeof(double))
                return ref Unsafe.As<double,T>(ref F64<S>().As(ref src));
            else
                throw no<T>();

        }
    }

    public readonly struct AsNumeric<R,S,T> : IAs<S,T>
        where T : unmanaged
        where R : unmanaged, IAs<S,T>
    {
        [MethodImpl(Inline)]
        public static implicit operator R(AsNumeric<R,S,T> src)
            => src.Reification;

        readonly R Reification;

        [MethodImpl(Inline)]
        internal AsNumeric(R reification)
        {
            this.Reification = reification;
        }

        [MethodImpl(Inline)]
        public T As(S src)
            => Reification.As(src);

        [MethodImpl(Inline)]
        public ref T As(ref S src)
            => ref Reification.As(ref src);
    }

    public readonly struct AsU8<S> : IAs<AsU8<S>,S,byte>
    {
        [MethodImpl(Inline)]
        public byte As(S src)
            => Unsafe.As<S,byte>(ref src);

        [MethodImpl(Inline)]
        public ref byte As(ref S src)
            => ref Unsafe.As<S,byte>(ref src);
    }

    public readonly struct AsU16<S> : IAs<AsU16<S>,S,ushort>
    {
        [MethodImpl(Inline)]
        public ushort As(S src)
            => Unsafe.As<S,ushort>(ref src);

        [MethodImpl(Inline)]
        public ref ushort As(ref S src)
            => ref Unsafe.As<S,ushort>(ref src);
    }

    public readonly struct AsU32<S> : IAs<AsU32<S>,S,uint>
    {
        [MethodImpl(Inline)]
        public uint As(S src)
            => Unsafe.As<S,uint>(ref src);

        [MethodImpl(Inline)]
        public ref uint As(ref S src)
            => ref Unsafe.As<S,uint>(ref src);
    }

    public readonly struct AsU64<S> : IAs<AsU64<S>,S,ulong>
    {
        [MethodImpl(Inline)]
        public ulong As(S src)
            => Unsafe.As<S,ulong>(ref src);

        [MethodImpl(Inline)]
        public ref ulong As(ref S src)
            => ref Unsafe.As<S,ulong>(ref src);
    }

    public readonly struct AsI8<S> : IAs<AsI8<S>,S,sbyte>
    {
        [MethodImpl(Inline)]
        public sbyte As(S src)
            => Unsafe.As<S,sbyte>(ref src);

        [MethodImpl(Inline)]
        public ref sbyte As(ref S src)
            => ref Unsafe.As<S,sbyte>(ref src);
    }

    public readonly struct AsI16<S> : IAs<AsI16<S>,S,short>
    {
        [MethodImpl(Inline)]
        public short As(S src)
            => Unsafe.As<S,short>(ref src);

        [MethodImpl(Inline)]
        public ref short As(ref S src)
            => ref Unsafe.As<S,short>(ref src);
    }

    public readonly struct AsI32<S> : IAs<AsI32<S>,S,int>
    {
        [MethodImpl(Inline)]
        public int As(S src)
            => Unsafe.As<S,int>(ref src);

        [MethodImpl(Inline)]
        public ref int As(ref S src)
            => ref Unsafe.As<S,int>(ref src);
    }

    public readonly struct AsI64<S> : IAs<AsI64<S>,S,long>
    {
        [MethodImpl(Inline)]
        public long As(S src)
            => Unsafe.As<S,long>(ref src);

        [MethodImpl(Inline)]
        public ref long As(ref S src)
            => ref Unsafe.As<S,long>(ref src);
    }

    public readonly struct AsF32<S> : IAs<AsF32<S>,S,float>
    {
        [MethodImpl(Inline)]
        public float As(S src)
            => Unsafe.As<S,float>(ref src);

        [MethodImpl(Inline)]
        public ref float As(ref S src)
            => ref Unsafe.As<S,float>(ref src);
    }

    public readonly struct AsF64<S> : IAs<AsF64<S>,S,double>
    {
        [MethodImpl(Inline)]
        public double As(S src)
            => Unsafe.As<S,double>(ref src);

        [MethodImpl(Inline)]
        public ref double As(ref S src)
            => ref Unsafe.As<S,double>(ref src);
    }
}