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

    [Flags]
    public enum AsciTableKind : byte
    {
        None = 0,

        Digits = 1,

        LowerLetters = 2,

        UpperLetters = 4,
    }

    public readonly struct AsciTable
    {
        public AsciTableKind Kind {get;}

        public sbyte Count {get;}

        readonly sbyte Min {get;}

        readonly sbyte Max {get;}

        public AsciTable(AsciTableKind kind, AsciCharCode min, AsciCharCode max)
        {
            Kind = kind;
            Min = (sbyte)min;
            Max = (sbyte)max;
            Count = (sbyte)((sbyte)(Max - Min) + 1);
        }

        public ReadOnlySpan<AsciCharCode> Codes
        {
            [MethodImpl(Inline), Op]
            get => AsciSymbols.codes(Min, Count);
        }

        public ReadOnlySpan<AsciSymbol> Symbols
        {
            [MethodImpl(Inline), Op]
            get => recover<AsciCharCode,AsciSymbol>(Codes);
        }

        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline), Op]
            get => AsciSymbols.chars(Min,Count);
        }
    }
}