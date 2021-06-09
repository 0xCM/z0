//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using CC = AsciCode;
    using K = BitCharKind;

    [SymbolSource]
    public enum BitCharKind : byte
    {
        [Symbol("0")]
        Off = CC.d0,

        [Symbol("1")]
        On = CC.d1,

        [Symbol("|")]
        SectionSep = CC.Pipe,

        [Symbol(" ")]
        SegSep = CC.Space,

        [Symbol("[")]
        LeftFence = CC.LBracket,

        [Symbol("]")]
        RightFence = CC.RBracket,

        [Symbol(" ")]
        Space = CC.Space,
    }

    public enum BitCharIndex : byte
    {
        Off = 0,

        On = 1,

        SectionSep = 2,

        SegSep = 3,

        LeftFence = 4,

        RightFence = 5,

        Space = 6,
    }

    partial struct BitChars
    {
        internal readonly struct CharData
        {
            public const string Off = "0";

            public const string On = "0";

            public const string SectionSep = "|";

            public const string SegSep = " ";

            public const string LeftFence = "[";

            public const string RightFence = "]";

            public const string Space = " ";

            public const string CharText = Off + On + SectionSep + SegSep + LeftFence + RightFence + Space;

            public ReadOnlySpan<char> Chars
            {
                [MethodImpl(Inline)]
                get => CharText;
            }

            public static ReadOnlySpan<BitCharKind> Kinds
                => new BitCharKind[7]{K.On, K.Off, K.SectionSep, K.SegSep, K.LeftFence, K.RightFence, K.Space};
        }
    }
}