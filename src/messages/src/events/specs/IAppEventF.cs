//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an F-bound polymorphic application event reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IAppEvent<F> : IAppEvent, INullary<F>
        where F : struct, IAppEvent<F>
    {
        string IAppEvent.Description
            => typeof(F).DisplayName();

        new F Content => (F)this;

        object IAppEvent.Content
            => Content;                
    }
}