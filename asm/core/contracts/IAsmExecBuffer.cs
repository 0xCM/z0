
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Defines service contract for a caller-disposed native execution buffer
    /// </summary>
    public interface IAsmExecBuffer : IAsmServiceAllocation
    {                
        /// <summary>
        /// The buffer length
        /// </summary>
        int Length {get;}                

        /// <summary>
        /// Specifies a representation of the buffer that can be safely exposed/passed to client code 
        /// without involving buffer ownership semantics
        /// </summary>
        BufferToken Token {get;}
    }   
}