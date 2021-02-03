//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using I = IntegerKind;
    using F = FloatKind;

    [System.Flags]
    public enum NumericKind : ushort
    {
        None = 0,

        Bit = DataKind.Bit,

        Int2u = I.Int2u,

        Int2i = I.Int2i,

        Int3 = I.Int3u,

        Int3i = I.Int3i,

        Int4u = I.Int4u,

        Int4i = I.Int4i,

        Int5u = I.Int5u,

        Int5i = I.Int5i,

        Int6u = I.Int6u,

        Int6i = I.Int6i,

        Int7u = I.Int7u,

        Int7i = I.Int7i,

        Int8u = I.Int8u,

        Int8i = I.Int8i,

        Int16u = I.Int64u,

        Int16i = I.Int16i,

        Float16 = F.Float16,

        Int32u = I.Int32u,

        Int32i = I.Int32i,

        Float32 = F.Float32,

        Int64u = I.Int64u,

        Int64i = I.Int64i,

        Float64 = F.Float64,

        Int128u = I.Int128u,

        Int128i = I.Int128i,

        Float128 = F.Float128,

        Int256u = I.Int256u,

        Int256i = I.Int256i,

        Float256 = F.Float256,

        Int512u = I.Int512u,

        Int512i = I.Int512i,

        Float512 = F.Float512,
    }
}