//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IDataFlow : ITextual
    {

    }

    /// <summary>
    /// Characterizes a data flow
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [Free]
    public interface IDataFlow<S,T> : IDataFlow
    {
        S Source {get;}

        T Target {get;}

        string ITextual.Format()
            => text.format(RenderPatterns.ArrowAxB, Source, Target);
    }

    [Free]
    public interface IDataFlow<T> : IDataFlow<T,T>
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
        string ITextual.Format()
            => text.format("{0} -> {1} | {2}", Source, Target, Result);
    }
}