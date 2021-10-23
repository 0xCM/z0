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

    public unsafe readonly struct ConstLabels
    {
        readonly Ptr<char> PSrc;

        readonly int Length;

        [MethodImpl(Inline)]
        internal ConstLabels(Ptr<char> pSrc, int length)
        {
            PSrc = pSrc;
            Length = length;
        }

        [MethodImpl(Inline)]
        internal ConstLabels(ReadOnlySpan<char> src)
        {
            PSrc = gptr(first(src));
            Length = src.Length;;
        }
    }
}