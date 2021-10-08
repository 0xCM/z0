//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRelation
    {
        Key<uint> Key {get;}

        RelationKind Kind {get;}

        dynamic Source {get;}

        dynamic Target {get;}
    }


    /// <summary>
    /// Characterizes a directed relation from a source to a target
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    [Free]
    public interface IRelation<S,T> : IRelation
    {
        new S Source {get;}

        new T Target {get;}

        dynamic IRelation.Source
            => Source;

        dynamic IRelation.Target
            => Target;
    }

    [Free]
    public interface IRelation<T> : IRelation<T,T>
    {

    }

    [Free]
    public interface IRelation<K,S,T> : IRelation<S,T>
    {
        new K Kind {get;}

        RelationKind IRelation.Kind
            => RelationKind.Parametric;

        dynamic IRelation.Source
            => Source;

        dynamic IRelation.Target
            => Target;
    }
}