//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface ICaptureServices : TAsmCore
    {
        IImmSpecializer ImmSpecializer(IAsmFunctionDecoder decoder);        

        /// <summary>
        /// Creates a service that extracts data that lives in memory using a caller-suppled working buffer
        /// </summary>
        /// <param name="buffer">The working buffer</param>
        IMemoryExtractor MemoryExtractor(byte[] buffer);

        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        IAsmFunctionDecoder AsmDecoder(in AsmFormatSpec? format = null);

        /// <summary>
        /// Creates a code extractor with an optionally-specified buffer length
        /// </summary>
        /// <param name="bufferlen">The desired buffer length</param>
        IMemberExtractor HostExtractor(int? bufferlen = null);


        IAsmFunctionDecoder DefaultFunctionDecoder {get;}
    }
}