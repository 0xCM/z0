//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a directed dependency d:S -> T from a client s:S to a suppler t:T
    /// </summary>
    /// <typeparam name="S">The source client type</typeparam>
    /// <typeparam name="T">The target supplier type</typeparam>
    public interface IDependency<S,T>
    {
        S Source {get;}

        T Target {get;}
    }


}