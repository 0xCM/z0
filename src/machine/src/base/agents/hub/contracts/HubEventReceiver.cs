//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate void HubEventReceiver(IAppEvent e);

    [SuppressUnmanagedCodeSecurity]
    public delegate void HubEventReceiver<E>(in E e)
        where E : struct, IAppEvent;
}