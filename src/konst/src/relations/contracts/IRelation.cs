//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    /// <summary>
    /// Characterizes a directed relation from a source to a target
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    public interface IRelation<S,T>
    {
        S Source {get;}

        T Target {get;}
    }

}