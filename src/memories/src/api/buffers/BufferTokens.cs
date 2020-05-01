
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct BufferTokens : IBufferTokenSource
    {
        readonly IBufferToken[] Index;

        [MethodImpl(Inline)]
        public static implicit operator BufferTokens(IBufferToken[] src)
            => new BufferTokens(src);

        [MethodImpl(Inline)]
        public BufferTokens(IBufferToken[] index)
        {
            this.Index = index;
        }

        public IBufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => Index[(int)id];
        }
    }
}