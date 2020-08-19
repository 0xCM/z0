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
    /// Characterizes a flow that represents a data movement from A -> B, or, in this case, S -> T
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [Free]
    public interface IDataFlow<S,T> : IDataFlow
    {
        S Source {get;}

        T Target {get;}

        string ITextual.Format()
            => text.format(RenderPatterns.Arrow, Source, Target);
    }
}