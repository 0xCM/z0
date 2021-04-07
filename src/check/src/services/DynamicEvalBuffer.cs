//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DynamicEvalBuffer : IDisposable
    {
        public static DynamicEvalBuffer create(uint length, byte count)
            => new DynamicEvalBuffer(length,count);

        readonly NativeBuffer BufferAlloc;

        public readonly BufferTokens Tokens {get;}

        public DynamicEvalBuffer(uint length, byte count)
            => Tokens = Buffers.alloc(length, count, out BufferAlloc).Tokenize();

        public void Dispose()
            => BufferAlloc.Dispose();

        public ref readonly BufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => ref Tokens[id];
        }
    }
}