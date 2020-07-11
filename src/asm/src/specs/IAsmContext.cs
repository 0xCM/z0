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

        TAppPaths TAppEnv.AppPaths
             => ContextRoot.AppPaths;

        IAppSettings TAppEnv.Settings 
            => ContextRoot.Settings;

        IPolyrand IPolyrandProvider.Random 
            => ContextRoot.Random;

        IAppMsgQueue MessageQueue 
            => ContextRoot.MessageQueue;

        Action<IAppMsg> MessageRelay
            => ContextRoot.MessageRelay;

        /// <summary>
        /// The capture archive root
        /// </summary>
        FolderPath CaptureRoot 
            => ContextRoot.AppPaths.CaptureRoot;

        /// <summary>
        /// The hosts known to the context
        /// </summary>
        IApiHost[] Hosts 
            => Api.Hosts;

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
        /// The primary capture archive, predicated on the context-specified root path
        /// </summary>
        TPartCaptureArchive RootCaptureArchive 
            => Archives.Services.CaptureArchive(CaptureRoot);

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

        /// <summary>
        /// Provides access to dynamic operator production facilities
        /// </summary>
        IDynexus Dynamic 
            => CaptureServices.Dynexus;

        /// <summary>
        /// Provides access to immeditate specialization services
        /// </summary>
        IImmSpecializer ImmServices 
            => CaptureServices.ImmSpecializer(Decoder);

        AsmWriterFactory WriterFactory 
            => CaptureServices.AsmWriterFactory;
        
        IEvalWorkflow CreateEvalWorkflow(AsmArchiveConfig config, uint buffersize)
            => Evaluate.workflow(Apps.context(Api, Random, Settings, AppMsgExchange.Create(ContextRoot)), Random, config.ArchiveRoot, buffersize);

        /// <summary>
        /// The context writer factory
        /// </summary>
        IAsmFunctionWriter Writer(FilePath dst)
            => WriterFactory(dst, Formatter); 
    }   
}