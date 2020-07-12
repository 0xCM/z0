//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public delegate void EncodedEventReceiver(IEncodedEvent e);

    [SuppressUnmanagedCodeSecurity]
    public delegate void EncodedEventReceiver<E>(in E e)
        where E : struct, IEncodedEvent;
}