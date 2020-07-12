//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a reified application event
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IAppEvent<F> : IAppEvent, INullary<F>
        where F : struct, IAppEvent<F>
    {
        string IAppEvent.Description
            => typeof(F).Name;

        new F Content 
            => (F)this;

        F INullary<F>.Zero 
            => default;

        object IAppEvent.Content
            => Content;                
    }
}