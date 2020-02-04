//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class HK
    {
        [MethodImpl(Inline)]
        public static Numeric nk()
            => default;

        [MethodImpl(Inline)]
        public static Numeric<T> nk<T>(T t = default)
            where T : unmanaged
                => default;

        public readonly struct Numeric : INumeric
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Numeric src)
                => INumeric.TypeClass;                                
        }        
    
        public readonly struct Numeric<T> : INumeric<T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Numeric<T> src)
                =>  INumeric.TypeClass;

            [MethodImpl(Inline)]
            public static implicit operator NumericKind(Numeric<T> src)
                => NumericType.kind<T>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Numeric<T> src)
                =>  new TypeKind<T>(INumeric.TypeClass);

            [MethodImpl(Inline)]
            public static implicit operator Numeric(Numeric<T> src)
                =>  default;                    
        }

        public static Numeric<byte> u8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<sbyte> i8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<ushort> u16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<short> i16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<uint> u32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<int> i32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<ulong> u64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<long> i64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<float> f32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<double> f64
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}