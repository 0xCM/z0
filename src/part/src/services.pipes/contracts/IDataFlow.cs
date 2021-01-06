//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataFlow : ILink
    {

    }

    /// <summary>
    /// Characterizes a data flow
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [Free]
    public interface IDataFlow<S,T> : IDataFlow, ILink<S,T>
    {

    }

    [Free]
    public interface IDataFlow<T> : IDataFlow<T,T>
    {

    }
}