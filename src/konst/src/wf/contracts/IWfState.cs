//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Attaches a state/context to a <see cref='IWfShell'/>
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    [Free]
    public interface IWfState<S>
    {
        IWfShell Wf {get;}

        S State {get;}
    }
}