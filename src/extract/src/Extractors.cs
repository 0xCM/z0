//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct Extractors : IExtractors
    {
        public static IExtractors Services => default(Extractors);     

        public const int DefaultBufferLength = Pow2.T14 + Pow2.T08;

        public static Option<LocatedCode> parse(LocatedCode src, byte[] buffer)
        {
            if(ExtractParsers.parse(src, buffer, out var dst))
                return Option.some(dst);
            else
                return Option.none<LocatedCode>();
        }   

        [MethodImpl(Inline)]
        public static LocatedCode extract(MemoryAddress src, byte[] buffer)
        {
            Span<byte> target = buffer;
            var length = MemoryReaderService.Service.Read(src, target);            
            return new LocatedCode(src, sys.array(target.Slice(0,length)));
        }
    }
}