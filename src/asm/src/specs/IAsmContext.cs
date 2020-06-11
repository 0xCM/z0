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
        /// The api collection known to the context
        /// </summary>
        IApiSet ApiSet {get;}
        
        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatSpec AsmFormat {get;}

        /// <summary>
        /// The context formatter
        /// </summary>
        IAsmFormatter Formatter {get;}

        /// <summary>
        /// The context decoder
        /// </summary>
        IAsmFunctionDecoder Decoder {get;}

        /// <summary>
        /// The context writer factory
        /// </summary>
        IAsmFunctionWriter Writer(FilePath dst);            

        /// <summary>
        /// The capture service
        /// </summary>
        ICaptureCore CaptureCore {get;}       

        /// <summary>
        /// Provides access to dynamic operator production facilities
        /// </summary>
        IDynexus Dynamic {get;}

        /// <summary>
        /// Provides access to immeditate specialization services
        /// </summary>
        IImmSpecializer ImmServices {get;}

        /// <summary>
        /// Reveals the context-predicated service factory
        /// </summary>
        IAsmContextual Contextual {get;}

        /// <summary>
        /// The capture archive root
        /// </summary>
        FolderPath RootCapturePath => Env.Current.LogDir;

        /// <summary>
        /// The hosts known to the context
        /// </summary>
        IApiHost[] Hosts => ApiSet.Hosts;

        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        int DefaultBufferLength => Pow2.T14;

        /// <summary>
        /// The primary capture archive, predicated on the context-specified root path
        /// </summary>
        ICaptureArchive RootCaptureArchive 
            => Archives.Services.CaptureArchive(RootCapturePath);

        /// <summary>
        /// A root archive descendant narrowed by area/subject
        /// </summary>
        /// <param name="area">Root stratification</param>
        /// <param name="subject">Area stratification</param>
        ICaptureArchive CaptureArchive(FolderName area, FolderName subject) 
            => RootCaptureArchive.Narrow(area,subject);
    }   
}