//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines factories for ams core stateless services
    /// </summary>
    public interface IAsmStatelessCore : IAsmStateless
    {
        IMemoryExtractor MemoryExtractor(byte[] buffer);

        ICaptureControl CaptureControl(ICaptureService capture);

        /// <summary>
        /// Creates a capture serivce predicated, or not, on an optionally-specified divination service
        /// </summary>
        /// <param name="diviner">A divination service, or not</param>
        ICaptureService CaptureService(IMultiDiviner diviner = null);

        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        IAsmFunctionDecoder FunctionDecoder(in AsmFormatSpec? format = null);

        /// <summary>
        /// Creates an instruction decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        IAsmInstructionDecoder InstructionDecoder(in AsmFormatSpec? format = null);

        /// <summary>
        /// Creates a code extractor with an optionally-specified buffer length
        /// </summary>
        /// <param name="bufferlen">The desired buffer length</param>
        IHostCodeExtractor HostExtractor(int? bufferlen = null);

        /// <summary>
        /// Creates a memory extraction parser over a caller-supplied work buffer
        /// </summary>
        /// <param name="buffer">The working buffer</param>
        IMemoryExtractParser MemoryExtractParser(byte[] buffer);
    }
}