//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDependency : IRelation
    {
        RelationKind IRelation.Kind
            => RelationKind.Dependency;
    }

    /// <summary>
    /// Characterizes a depency relation between nodes of heterogeneous type
    /// </summary>
    /// <typeparam name="T">The node type</typeparam>
    [Free]
    public interface IDependency<S,T> : IDependency, IRelation<S,T>
    {

    }

    [Free]
    public interface IDependency<T> : IDependency<T,T>
    {

    }
}