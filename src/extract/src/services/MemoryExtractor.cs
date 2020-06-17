//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly struct MemoryExtractor : IMemoryExtractor
    {
        public readonly IMemoryReader Reader;

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static IMemoryExtractor Create(byte[] buffer)
            => new MemoryExtractor(buffer);

        [MethodImpl(Inline)]
        internal MemoryExtractor(byte[] buffer)
        {
            this.Buffer = buffer;
            this.Reader =  MemoryReader.Service;
        }

        [MethodImpl(Inline)]
        public Option<LocatedCode> Extract(MemoryAddress src)
        {
            try
            {
                Span<byte> buffer = Buffer.Clear();
                var length = Reader.Read(src, buffer);            
                return LocatedCode.Define(src, buffer.Slice(0,length).ToArray());
            }
            catch(Exception e)
            {
                term.error(e);
                return none<LocatedCode>();
            }
        }
    }
}