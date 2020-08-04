//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    /// <summary>
    /// Defines a nexus of shared state and services for assembly-related services
    /// </summary>
    public interface IAsmContext : IAppMsgQueue, IPolyrandProvider, IAppMsgContext
    {
        /// <summary>
        /// The root of this context
        /// </summary>
        IAppContext ContextRoot {get;}

        ICaptureServices CaptureServices {get;}

        /// <summary>
        /// The capture service
        /// </summary>
        ICaptureCore CaptureCore  
            => CaptureServices.CaptureCore;

        IAppMsgQueue MessageQueue 
            => ContextRoot.MessageQueue;
 
        /// <summary>
        /// The api collection known to the context
        /// </summary>
        IApiSet Api 
            => ContextRoot;

        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        int DefaultBufferLength 
            => Pow2.T14;

        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatSpec AsmFormat
            => AsmFormatSpec.DefaultStreamFormat;           

        /// <summary>
        /// The context formatter
        /// </summary>
        IAsmFormatter Formatter 
            => CaptureServices.Formatter(AsmFormat);

        /// <summary>
        /// The context decoder
        /// </summary>
        IAsmFunctionDecoder Decoder 
            => CaptureServices.AsmDecoder(AsmFormat);    
    }   
}