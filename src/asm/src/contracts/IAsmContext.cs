//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
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

        IApiCatalogDataset ApiGlobal
            => ContextRoot.ApiGlobal;

        /// <summary>
        /// The capture service
        /// </summary>
        ICaptureCore CaptureCore
            => CaptureServices.CaptureCore;

        IAppMsgQueue MessageQueue
            => ContextRoot.MessageQueue;

        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        uint DefaultBufferLength
            => Pow2.T16;

        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatConfig FormatConfig
            => AsmFormatConfig.DefaultStreamFormat;

        /// <summary>
        /// The context formatter
        /// </summary>
        IAsmRoutineFormatter Formatter
            => AsmServices.formatter(FormatConfig);

        /// <summary>
        /// The context decoder
        /// </summary>
        IAsmDecoder RoutineDecoder
            => CaptureServices.RoutineDecoder(FormatConfig);
    }
}