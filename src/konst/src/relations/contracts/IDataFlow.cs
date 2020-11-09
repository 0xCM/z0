//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataFlow : IArrow
    {

    }

    /// <summary>
    /// Characterizes a data flow
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [Free]
    public interface IDataFlow<S,T> : IDataFlow, IArrow<S,T>
    {

    }

    /// <summary>
    /// Characterizes an executed data flow
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [Free]
    public interface IDataFlow<S,T,R> : IDataFlow<S,T>
    {
        R Result {get;}

        string IIdentified.Identifier
            => string.Format("{0} -> {1} >> {2}", Source, Target, Result);
    }

    [Free]
    public interface IDataFlow<T> : IDataFlow<T,T>
    {

    }
}