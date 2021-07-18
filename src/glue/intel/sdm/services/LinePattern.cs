//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct LinePattern
    {
        readonly Index<string> Data;

        [MethodImpl(Inline)]
        public LinePattern(string[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator LinePattern(string[] src)
            => new LinePattern(src);
    }
}