//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryExtractor : IMemoryExtractor
    {
        public readonly MemoryReaderService Reader;

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static IMemoryExtractor service(byte[] buffer)
            => new MemoryExtractor(buffer);

        [MethodImpl(Inline)]
        public MemoryExtractor(byte[] buffer)
        {
            Buffer = buffer;
            Reader =  MemoryReaderService.Service;
        }

        [MethodImpl(Inline)]
        public Option<LocatedCode> Extract(MemoryAddress src)
        {
            try
            {
                Span<byte> buffer = Buffer.Clear();
                var length = Reader.Read(src, buffer);            
                return new LocatedCode(src, buffer.Slice(0,length).ToArray());
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<LocatedCode>();
            }
        }
    }
}