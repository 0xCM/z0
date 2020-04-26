//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System.Reflection;

    /// <summary>
    /// Defines a nexus of shared state and services for assembly-related services
    /// </summary>
    public interface IAsmContext : IAppMsgQueue, IPolyrandProvider, IAppMsgContext
    {
        IApiSet ApiSet {get;}
        
        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatConfig AsmFormat {get;}

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
        ICaptureService CaptureService {get;}       

        /// <summary>
        /// The capture control service
        /// </summary>
        ICaptureControl CaptureControl {get;}

        /// <summary>
        /// Provides access to dynamic operator production facilities
        /// </summary>
        IDynamicOps Dynamic {get;}

        /// <summary>
        /// The capture archive root
        /// </summary>
        FolderPath RootCapturePath => Env.Current.LogDir;

        ICaptureArchive RootCaptureArchive 
            => Z0.CaptureArchive.Create(RootCapturePath);

        ICaptureArchive CaptureArchive(FolderName area, FolderName subject) 
            => RootCaptureArchive.Narrow(area,subject);

        IApiHost[] Hosts => ApiSet.Hosts;

        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        int DefaultBufferLength => Pow2.T14;
    }   
}