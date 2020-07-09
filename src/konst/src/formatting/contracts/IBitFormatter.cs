//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFormatter : IFormatter
    {
        void Format(ReadOnlySpan<byte> src, int maxbits, Span<char> dst);
    }


}