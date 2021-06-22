//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = AsciSymbols;

    public readonly struct AsciTable
    {
        public AsciTableKind Kind {get;}

        public sbyte Count {get;}

        readonly sbyte Min {get;}

        readonly sbyte Max {get;}

        public AsciTable(AsciTableKind kind, AsciCode min, AsciCode max)
        {
            Kind = kind;
            Min = (sbyte)min;
            Max = (sbyte)max;
            Count = (sbyte)((sbyte)(Max - Min) + 1);
        }

        public ReadOnlySpan<AsciCode> Codes
        {
            [MethodImpl(Inline), Op]
            get => api.codes(Min, Count);
        }

        public ReadOnlySpan<AsciSymbol> Symbols
        {
            [MethodImpl(Inline), Op]
            get => recover<AsciCode,AsciSymbol>(Codes);
        }

        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline), Op]
            get => api.chars(Min,Count);
        }
    }
}