//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a reified event with parametric content
    /// </summary>
    /// <typeparam name="H">The event type</typeparam>
    /// <typeparam name="T">The content type</typeparam>
    [Free]
    public interface IWfEvent<H,T> : IWfEvent<H>
        where H : IWfEvent<H,T>, new()
    {
        EventPayload<T> Payload => default;
    }
}