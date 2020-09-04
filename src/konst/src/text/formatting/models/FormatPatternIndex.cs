//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FormatPatternIndex
    {
        readonly TableSpan<FormatPattern> Data;

        [MethodImpl(Inline)]
        public static implicit operator FormatPatternIndex(FormatPattern[] src)
            => new FormatPatternIndex(src);

        [MethodImpl(Inline)]
        public FormatPatternIndex(FormatPattern[] src)
            => Data = src;

        public Count32 Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<FormatPattern> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref readonly FormatPattern this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}