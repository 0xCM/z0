//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    readonly struct AsmMemoryExtractor : IAsmMemoryExtractor
    {
        public IAsmContext Context {get;}

        public readonly IMemoryReader Reader;

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static IAsmMemoryExtractor Create(IAsmContext context, byte[] buffer)
            => new AsmMemoryExtractor(context, buffer);

        [MethodImpl(Inline)]
        AsmMemoryExtractor(IAsmContext context, byte[] buffer)
        {
            this.Context = context;
            this.Buffer = buffer;
            this.Reader = context.MemoryReader();
        }

        [MethodImpl(Inline)]
        public Option<MemoryEncoding> Extract(MemoryAddress src)
        {
            try
            {
                Span<byte> buffer = Buffer.Clear();
                var length = Reader.Read(src, buffer.Length, buffer);            
                return MemoryEncoding.Define(src, buffer.Slice(0,length).ToArray());
            }
            catch(Exception e)
            {
                term.error(e);
                return none<MemoryEncoding>();
            }
        }
    }
}