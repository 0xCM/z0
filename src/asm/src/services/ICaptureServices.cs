//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ICaptureServices : IAsmCore
    {
        IImmSpecializer ImmSpecializer(IAsmFunctionDecoder decoder);        
        
        IHostAsmArchiver ImmFunctionArchive(ApiHostUri host, IAsmFormatter formatter, FolderPath dst);        

        IMemoryExtractor MemoryExtractor(byte[] buffer);

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
        IAsmFunctionDecoder AsmDecoder(in AsmFormatSpec? format = null);

        /// <summary>
        /// Creates a code extractor with an optionally-specified buffer length
        /// </summary>
        /// <param name="bufferlen">The desired buffer length</param>
        IHostCodeExtractor HostExtractor(int? bufferlen = null);
    }
}