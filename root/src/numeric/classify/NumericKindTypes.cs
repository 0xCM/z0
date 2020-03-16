//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using NK = NumericKind;
        
    public static class NumericKinds
    { 
        public readonly struct I8 : INumericKindType<sbyte> 
        { 
            public static implicit operator NumericKind(I8 src) => NK.I8; 
        }

        public readonly struct U8 : INumericKindType<byte> 
        {
            public static implicit operator NumericKind(U8 src) => NK.U8; 
        }

        public readonly struct I16 : INumericKindType<short> 
        {
            public static implicit operator NumericKind(I16 src) => NK.I16; 
        }

        public readonly struct U16 : INumericKindType<ushort> 
        {
            public static implicit operator NumericKind(U16 src) => NK.U16; 
        }

        public readonly struct I32 : INumericKindType<int>
        {
            public static implicit operator NumericKind(I32 src) => NK.I32; 

        }

        public readonly struct U32 : INumericKindType<uint>
        {
            public static implicit operator NumericKind(U32 src) => NK.U32; 
        }

        public readonly struct I64 : INumericKindType<long>
        {
            public static implicit operator NumericKind(I64 src) => NK.I64;
        }

        public readonly struct U64 : INumericKindType<ulong>
        {
            public static implicit operator NumericKind(U64 src) => NK.U64;
        }

        public readonly struct F32 : INumericKindType<float>
        {
            public static implicit operator NumericKind(F32 src) => NK.F32;
        }

        public readonly struct F64 : INumericKindType<double>
        {
            public static implicit operator NumericKind(F64 src) => NK.F64;            
        }

        public static I8 i8 => default(I8);

        public static U8 u8 => default(U8);

        public static I16 i16 => default(I16);

        public static U16 u16 => default(U16);

        public static I32 i32 => default(I32);

        public static U32 u32 => default(U32);

        public static I64 i64 => default(I64);

        public static U64 u64 => default(U64);

        public static F32 f32 => default(F32);

        public static F64 f64 => default(F64);
    }
}