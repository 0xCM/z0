//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Defines assembly role classifiers
    /// </summary>
    public enum AssemblyRole
    {
        /// <summary>
        /// Indicates the absence of a role classification
        /// </summary>
        Unsclassified = 0,

        /// <summary>
        /// Classifies an assembly as a test host/runner
        /// </summary>
        Test,

        /// <summary>
        /// Classifies an assembly as a benchmark host/runner
        /// </summary>
        Bench,

        /// <summary>
        /// Classifies an assembly as an api library
        /// </summary>
        Library,
        
        /// <summary>
        /// Classifies an assembly with an entry point that directs/orchestrates operations
        /// </summary>
        Controller
    }

}