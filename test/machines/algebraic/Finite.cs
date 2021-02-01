//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDiscreteGroup<S> : IGroupLike<S>
        where S : IDiscreteGroup<S>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a discrete group structure
    /// </summary>
    /// <typeparam name="T">The operational type</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IDiscreteGroup<S,T> : IGroupLike<S,T>, IDeferredSet<S,T>
        where S : IDiscreteGroup<S,T>, new()
    {

    }

    public interface IFiniteGroup<S,T> : IDiscreteGroup<S,T>
        where S : IFiniteGroup<S,T>, new()
    {


    }

    public interface IDiscreteAbelianGroup<S,T> : IGroupA<S,T>, IDeferredSet<S,T>
        where S : IDiscreteAbelianGroup<S,T>, new()
    {

    }

    public interface IFiniteAbelianGroup<S,T> : IDiscreteAbelianGroup<S,T>, IDeferredSet<S,T>
        where S : IFiniteAbelianGroup<S,T>, new()
    {


    }
}