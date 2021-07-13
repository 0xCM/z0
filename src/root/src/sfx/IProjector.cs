//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a structural transformation function
    /// </summary>
    /// <typeparam name="A">The source domain type</typeparam>
    /// <typeparam name="B">The target domain type</typeparam>
    [Free, SFx]
    public interface ISFxProjector<A,B> : IFunc<A,B>
    {

    }

    /// <summary>
    /// Characterizes a projector that is also a unary operator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Free, SFx]
    public interface ISFxProjector<T> : ISFxProjector<T,T>, IUnaryOp<T>
    {

    }
}