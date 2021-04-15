//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

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

        public byte Count {get;}

        readonly AsciCharCode Min {get;}

        readonly AsciCharCode Max {get;}

        public AsciTable(AsciTableKind kind, AsciCharCode min, AsciCharCode max)
        {
            Kind = kind;
            Min = min;
            Max = max;
            Count = (byte)((byte)(Max - Min) + 1);
        }

        public ReadOnlySpan<AsciCharCode> Codes
        {
            [MethodImpl(Inline), Op]
            get => slice(AsciCharData.Codes,(byte)Min,Count);
        }

        public ReadOnlySpan<AsciSymbol> Symbols
        {
            [MethodImpl(Inline), Op]
            get => recover<AsciCharCode,AsciSymbol>(Codes);
        }
    }
}