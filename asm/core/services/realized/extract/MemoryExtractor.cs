//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    readonly struct MemoryExtractor : IMemoryExtractor
    {
        public readonly IMemoryReader Reader;

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static IMemoryExtractor Create(IContext context, byte[] buffer)
            => new MemoryExtractor(context, buffer);

        [MethodImpl(Inline)]
        MemoryExtractor(IContext context, byte[] buffer)
        {
            this.Buffer = buffer;
            this.Reader = context.MemoryReader();
        }

        [MethodImpl(Inline)]
        public Option<Addressable> Extract(MemoryAddress src)
        {
            try
            {
                Span<byte> buffer = Buffer.Clear();
                var length = Reader.Read(src, buffer);            
                return Addressable.Define(src, buffer.Slice(0,length).ToArray());
            }
            catch(Exception e)
            {
                term.error(e);
                return none<Addressable>();
            }
        }
    }
}