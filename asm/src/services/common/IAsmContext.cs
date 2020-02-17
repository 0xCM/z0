//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AsmSpecs;

    using static zfunc;

    /// <summary>
    /// Defines a nexus of shared state and services for assembly-related services
    /// </summary>
    public interface IAsmContext : IContext
    {
        int ContextId {get;}
        
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
        /// The assemblies available to the context
        /// </summary>
        IAssemblyComposition Compostion {get;}

        /// <summary>
        /// Changes the default asm formatting configuration
        /// </summary>
        /// <param name="config">The new formatting configuration</param>
        IAsmContext WithFormat(AsmFormatConfig config);      

        IEnumerable<AssemblyId> Assemblies
            => from r in Compostion.Resolved
                select r.Id;
    }
}