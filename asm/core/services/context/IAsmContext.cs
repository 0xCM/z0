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
    public interface IAsmContext : IApiContext, IAppMsgQueue, IPolyrandProvider, IAppContext
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

        /// <summary>
        /// Encapsulates the state of the context
        /// </summary>
        AsmContextData State {get;}

        IAppPaths IAppEnv.Paths 
            => AppPathProvider.Create(Assembly.GetEntryAssembly().Id(), Env.Current.LogDir);  

    }   
}