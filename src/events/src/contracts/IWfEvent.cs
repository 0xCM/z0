//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a reified event
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    [Free]
    public interface IWfEvent<H> : IWfEvent, IAppEvent<H>
        where H : IWfEvent<H>, new()
    {

    }
}