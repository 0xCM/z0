//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using Asm;
    /// <summary>
    /// Defines a nexus of shared state and services for assembly-related services
    /// </summary>
    public interface IAsmContext : IComposedApiContext<IAsmContext>, IContext<AsmContextData>,  IAppMsgQueue, IPolyrandProvider
    {
        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        int DefaultBufferLength 
            => Pow2.T14;
        
        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatConfig AsmFormat {get;}

        /// <summary>
        /// Changes the default asm formatting configuration
        /// </summary>
        /// <param name="config">The new formatting configuration</param>
        IAsmContext WithFormat(AsmFormatConfig config);  

    }   
}