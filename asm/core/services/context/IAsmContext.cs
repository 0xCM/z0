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
    public interface IAsmContext : IAppMsgQueue, IPolyrandProvider, IAppContext
    {
        IApiSet ApiSet {get;}
        
        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatConfig AsmFormat {get;}

        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        int DefaultBufferLength 
            => Pow2.T14;        

        IAsmFormatter AsmFormatter {get;}

        IAsmFunctionDecoder AsmDecoder {get;}

        IAsmStreamWriter AsmWriter(FilePath dst);            
    }   
}