//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;

    public interface IBitFormatter : IFormatter
    {
        void Format(ReadOnlySpan<byte> src, int maxbits, Span<char> dst);
    }

    public interface IBitFormatter<T> : IFormatter<BitFormatConfig,T>
        where T : struct
    {
    }
}