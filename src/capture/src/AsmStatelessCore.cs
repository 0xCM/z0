//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Svc = Z0.Asm;
    
    using static Seed;

    public readonly struct AsmStatelessCore : IAsmStatelessCore
    {
        public static IAsmStatelessCore Factory => default(AsmStatelessCore);

        [MethodImpl(Inline)]
        public IMemoryExtractor MemoryExtractor(byte[] buffer)
            => Z0.MemoryExtractor.Create(buffer);     

        public IMultiDiviner Diviner => StatelessIdentity.Factory.Diviner;
        
        /// <summary>
        /// Creates a capture serivce predicated, or not, on an optionally-specified divination service
        /// </summary>
        /// <param name="diviner">A divination service, or not</param>
        [MethodImpl(Inline)]
        public ICaptureService CaptureService(IMultiDiviner diviner = null)
            => Svc.CaptureService.Create(diviner ?? Diviner);

        [MethodImpl(Inline)]
        public ICaptureControl CaptureControl(ICaptureService capture)
            => MemberCaptureControl.Create(capture);

        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        public IAsmFunctionDecoder FunctionDecoder(in AsmFormatSpec? format = null)
            => AsmFunctionDecoder.Create(format ?? AsmFormatSpec.Default);

        /// <summary>
        /// Creates an instruction decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        public IAsmInstructionDecoder InstructionDecoder(in AsmFormatSpec? format = null)
            => AsmInstructionDecoder.Create(format ?? AsmFormatSpec.Default);

        /// <summary>
        /// Creates a code extractor with an optionally-specified buffer length
        /// </summary>
        /// <param name="bufferlen">The desired buffer length</param>
        [MethodImpl(Inline)]
        public IHostCodeExtractor HostExtractor(int? bufferlen = null)
            => HostCodeExtractor.Create(bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        public IMemoryExtractParser MemoryExtractParser(byte[] buffer)
            => Z0.MemoryExtractParser.Create(buffer);
    }
}