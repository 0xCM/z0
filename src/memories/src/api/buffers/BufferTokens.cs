
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct BufferTokens : IBufferTokenSource
    {
        readonly IBufferToken[] Data;

        [MethodImpl(Inline)]
        public static implicit operator BufferTokens(IBufferToken[] src)
            => new BufferTokens(src);

        [MethodImpl(Inline)]
        public BufferTokens(IBufferToken[] src)
        {
            Data = src;
        }

        public IBufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => Data[(byte)id];
        }
    }
}