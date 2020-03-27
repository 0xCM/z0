//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Characterizes console-controlled, perhaps user-initiated, thread of execution
    /// </summary>
    public interface IShell
    {        
        /// <summary>
        /// Executes the shell-defined run-loop
        /// </summary>
        /// <param name="args">Run-loop state, sourced from the command-line arguments or elsewhere</param>
        void Run(params string[] args);                
    }
}