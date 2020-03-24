//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    using NK = NumericKind;


    /// <summary>
    /// Represents the parametrically-identified numeric kind
    /// </summary>
    public readonly struct NK<T> : INumericKind<T> 
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(NK<T> src)
            => NumericTypes.kind<T>();

        [MethodImpl(Inline)]
        public static implicit operator T(NK<T> src)
            => default;
    }

    public static class NumericKinds
    { 
        public readonly struct I8 : INumericKind<sbyte> 
        { 
            [MethodImpl(Inline)]
            public static implicit operator NK(I8 src) => NK.I8; 

            [MethodImpl(Inline)]
            public static implicit operator I8(NK<sbyte> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<sbyte>(I8 src) => default;
        }

        public readonly struct U8 : INumericKind<byte> 
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(U8 src) => NK.U8; 

            [MethodImpl(Inline)]
            public static implicit operator U8(NK<byte> src) => default(U8);

            [MethodImpl(Inline)]
            public static implicit operator NK<byte>(U8 src) => default(U8);
        }

        public readonly struct I16 : INumericKind<short> 
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(I16 src) => NK.I16; 

            [MethodImpl(Inline)]
            public static implicit operator I16(NK<short> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<short>(I16 src) => default;
        }

        public readonly struct U16 : INumericKind<ushort> 
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(U16 src) => NK.U16; 

            [MethodImpl(Inline)]
            public static implicit operator U16(NK<ushort> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<ushort>(U16 src) => default;
        }

        public readonly struct I32 : INumericKind<int>
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(I32 src) => NK.I32; 


            [MethodImpl(Inline)]
            public static implicit operator I32(NK<int> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<int>(I32 src) => default;
        }

        public readonly struct U32 : INumericKind<uint>
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(U32 src) => NK.U32; 

            [MethodImpl(Inline)]
            public static implicit operator U32(NK<uint> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<uint>(U32 src) => default;
        }

        public readonly struct I64 : INumericKind<long>
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(I64 src) => NK.I64;

            [MethodImpl(Inline)]
            public static implicit operator I64(NK<long> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<long>(I64 src) => default;
        }

        public readonly struct U64 : INumericKind<ulong>
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(U64 src) => NK.U64;

            [MethodImpl(Inline)]
            public static implicit operator U64(NK<ulong> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<ulong>(U64 src) => default;
        }

        public readonly struct F32 : INumericKind<float>
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(F32 src) => NK.F32;

            [MethodImpl(Inline)]
            public static implicit operator F32(NK<float> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<float>(F32 src) => default;

        }

        public readonly struct F64 : INumericKind<double>
        {
            [MethodImpl(Inline)]
            public static implicit operator NK(F64 src) => NK.F64;            

            [MethodImpl(Inline)]
            public static implicit operator F64(NK<float> src) => default;

            [MethodImpl(Inline)]
            public static implicit operator NK<double>(F64 src) => default;
        }

        public static NK<sbyte> i8 => default;

        public static NK<byte> u8 => default;

        public static NK<short> i16 => default;

        public static NK<ushort> u16 => default;

        public static NK<int> i32 => default;

        public static NK<uint> u32 => default;

        public static NK<long> i64 => default;

        public static NK<ulong> u64 => default;

        public static NK<float> f32 => default;

        public static NK<double> f64 => default;
    }
}