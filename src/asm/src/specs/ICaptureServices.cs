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
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        IAsmFunctionDecoder AsmDecoder(in AsmFormatSpec? format = null);

        /// <summary>
        /// Creates a code extractor with a specified buffer length
        /// </summary>
        /// <param name="bufferlen">The desired buffer length</param>
        IMemberExtractor HostExtractor(int bufferlen);

        IAsmFunctionDecoder DefaultFunctionDecoder {get;}

        ICaptureCore CaptureCore {get;}        
    }
}