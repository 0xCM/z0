//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    using Z0.Image;
    using Z0.MS;

    public struct ClrProcessData
    {
        /// <summary>
        /// Gets the list of CLR versions loaded into the process.
        /// </summary>
        public ClrDescription[] Runtimes;

        public ProcessModuleInfo[] Modules;
        
        public ClrProcessData(ClrDescription[] clr, ProcessModuleInfo[] modules)
        {
            Runtimes = clr;
            Modules = modules;
        }    
    }
}