//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a nexus of shared state and services for assembly-related services
    /// </summary>
    public interface IAsmContext : IComposedContext<IAsmContext>, IAppMsgQueue
    {
        int Identity {get;}

        /// <summary>
        /// The buffer length to use whenever a buffer length is unspecified
        /// </summary>
        int DefaultBufferLength 
            => Pow2.T14;
        
        IClrIndex ClrIndex {get;}

        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatConfig AsmFormat {get;}

        /// <summary>
        /// The default cil formatting configuration
        /// </summary>
        CilFormatConfig CilFormat {get;}

        /// <summary>
        /// Changes the default asm formatting configuration
        /// </summary>
        /// <param name="config">The new formatting configuration</param>
        IAsmContext WithFormat(AsmFormatConfig config);  

        /// <summary>
        /// Posts a text message to the context queue with optional severity
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Notify(string msg, AppMsgKind? severity = null)
            => Enqueue(msg,severity);

        /// <summary>
        /// Posts a message to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Notify(AppMsg msg)
            => Enqueue(msg);        


    }
}