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
    public interface IShell : IExecutable
    {        

    }

    /// <summary>
    /// Characterizes a reified shell
    /// </summary>
    public interface IShell<S> : IShell
        where S : IShell<S>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a reified shell with parametric context
    /// </summary>
    public interface IShell<S,C> : IShell
        where S : IShell<S,C>, new()
        where C : IContext    
    {
        
    }
}