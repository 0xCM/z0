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
        public static DynamicEvalBuffer create(ByteSize length, byte count)
            => new DynamicEvalBuffer(length,count);

        readonly NativeBuffers _Buffers;

        public BufferTokens Tokens {get;}

        public DynamicEvalBuffer(ByteSize size, byte count)
        {
            _Buffers = Buffers.native(size,count);
            Tokens = _Buffers.Tokenize();
        }

        public void Dispose()
            => _Buffers.Dispose();

        public ref readonly BufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => ref Tokens[id];
        }
    }
}