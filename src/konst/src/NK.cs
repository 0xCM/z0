//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using NK = NumericKind;

    partial struct Konst
    {
        public const NK UnsignedInts = NK.UnsignedInts;

        public const NK SignedInts = NK.SignedInts;

        public const NK Integers = NK.Integers;

        public const NK Floats = NK.Floats;

        public const NK AllNumeric = NK.All;

        public const NK Numeric8 = NK.Width8;

        public const NK Numeric16 = NK.Width16;

        public const NK Numeric32 = NK.Width32;

        public const NK Numeric64 = NK.Width64;

        public const NK Numeric8u = NK.U8;

        public const NK Numeric8i = NK.I8;

        public const NK Numeric16u = NK.U16;

        public const NK Numeric16i = NK.I16;

        public const NK Numeric32u = NK.U32;

        public const NK Numeric32i = NK.I32;

        public const NK Numeric64u = NK.U64;

        public const NK Numeric64i = NK.I64;

        public const NK Numeric32f = NK.F32;

        public const NK Numeric64f = NK.F64;

        public const NK Numeric8x16 = NK.Width8 | NK.Width16;

        public const NK Numeric8x16x32 = NK.Width8 | NK.Width16 | NK.Width32;

        public const NK Numeric16x32 = NK.Width16 | NK.Width32;

        public const NK Numeric16x32x64 = NK.Width16 | NK.Width32 | NK.Width64;

        public const NK Numeric16x32x64u = NK.U16 | NK.U32 | NK.U64;

        public const NK Numeric16x32x64i = NK.I16 | NK.I32 | NK.I64;

        public const NK Numeric32x64 = NK.Width32 | NK.Width64;

        public const NK Numeric8x16u = NK.U8 | NK.U16;

        public const NK Numeric8x16x32u = NK.U8 | NK.U16 | NK.U32;

        public const NK Numeric16x32u = NK.U16 | NK.U32;
        
        public const NK Numeric32x64u = NK.U32 | NK.U64;
    }
}