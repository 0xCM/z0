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
    public interface IAsmContext : IAppMsgQueue, IPolyrandContext, IAppMsgContext
    {
        IApiSet ApiSet {get;}
        
        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatConfig AsmFormat {get;}

        IAsmFormatter Formatter {get;}

        IAsmFunctionDecoder Decoder {get;}

        IFunctionStreamWriter Writer(FilePath dst);            

        ICaptureArchive EmissionPaths => CaptureArchive.Default;

        IApiHost[] Hosts => ApiSet.Hosts;

        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        int DefaultBufferLength => Pow2.T14;        

        ICaptureArchive Emissions(FolderName area, FolderName subject) => EmissionPaths.WithSubject(area,subject);
    }   
}