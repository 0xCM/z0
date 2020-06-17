//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;

    using Svc = Z0;

    public readonly struct Capture
    {
        public static ICaptureServices Services 
            => default(AsmWorkflows);

        public static ICaptureCore Core 
            => CaptureCore.Service;

        ILocatedCodeParser LocatedParser
            => LocatedCodeParser.Create(new byte[Pow2.T14]);

        [MethodImpl(Inline)]
        public IMemoryCapture Memory(IAsmContext context, int? bufferlen = null)
            => MemoryCaptureService.Create(context.Decoder, bufferlen);

        public IAsmFunctionDecoder DefaultFunctionDecoder
        {
            [MethodImpl(Inline)]
            get => AsmFunctionDecoder.Default;
        }

        [MethodImpl(Inline)]
        IMemoryCapture MemoryCapture(IAsmFunctionDecoder decoder, int? bufferlen = null)
            => MemoryCaptureService.Create(decoder, bufferlen);

        [MethodImpl(Inline)]
        IMemoryExtractor MemoryExtractor(byte[] buffer)
            => Svc.MemoryExtractor.Create(buffer);

        [MethodImpl(Inline)]
        IImmSpecializer ImmSpecializer(IAsmFunctionDecoder decoder)
            => new ImmSpecializer(decoder);        

        [MethodImpl(Inline)]
        IAsmFunctionDecoder AsmDecoder(in AsmFormatSpec? format)
            => new AsmFunctionDecoder(format ?? AsmFormatSpec.Default);

        [MethodImpl(Inline)]
        IMemberExtractor HostExtractor(int? bufferlen)
            => MemberExtractor.Create(bufferlen ?? Pow2.T14);
    }
}