//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    using VS = Sourced;

    public readonly struct PolyState
    {
        readonly TableSpan<byte> Data;

        public readonly IValueSource Source;
    }




    partial struct PolySource
    {
        readonly Span<bool> ZSeq;

        readonly Span<uint1> U1Seq;

        readonly Span<uint2> U2Seq;

        readonly Span<uint3> U3Seq;

        readonly Span<uint4> U4Seq;

        readonly Span<uint5> U5Seq;

        readonly Span<uint6> U6Seq;

        readonly Span<uint7> U7Seq;

        readonly Span<byte> U8Seq;

        readonly Span<byte> I8Seq;

        readonly Span<ushort> U16Seq;

        readonly Span<short> I16Seq;

        readonly Span<uint> U32Seq;

        readonly Span<int> I32Seq;

        readonly Span<long> U64Seq;

        readonly Span<ulong> I64Seq;

        readonly Span<float> F32Seq;

        readonly Span<double> F64Seq;

        readonly Span<decimal> F128Seq;

        readonly Span<char> C16Seq;

        readonly Span<DateTime> DTSeq;

        IValueSource Source;

        IValueSource<byte> U8;

        IValueSource<sbyte> I8;

        IValueSource<ushort> U16;

        IValueSource<short> I16;

        IValueSource<uint> U32;

        IValueSource<byte> I32;

        IValueSource<ulong> U64;

        IValueSource<long> I64;

        IValueSource<float> F32;

        IValueSource<double> F64;

        IValueSource<decimal> F128;

        IValueSource<AsciSymbol> C8;

        IValueSource<char> C16;

        IValueSource<char> DT;
    }
}