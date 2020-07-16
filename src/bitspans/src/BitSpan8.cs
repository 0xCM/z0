//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly ref struct BitSpan8
    {
        public static BitSpan8 Empty => default;
        
        internal readonly Span<byte> Data;

        [MethodImpl(Inline)]
        public BitSpan8(Span<byte> src)
        {
            Data = src;
        }
    }
}