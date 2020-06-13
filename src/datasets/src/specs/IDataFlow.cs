//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Characterizes a flow that represents a data movement from A -> B, or, in this case, S -> T
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IDataFlow<S,T>
    {
        S Source {get;}

        T Target {get;}
    }
}