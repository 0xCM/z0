//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    partial struct WfDelegates
    {
        [SuppressUnmanagedCodeSecurity]
        public delegate void EventHandler(IWfEvent src);

        [SuppressUnmanagedCodeSecurity]
        public delegate void EventHandler<E>(in E src)
            where E : struct, IWfEvent<E>;

        [SuppressUnmanagedCodeSecurity]
        public interface IEventHandler : IHandler<IWfEvent> { }

        [SuppressUnmanagedCodeSecurity]
        public interface IEventHandler<E> : IHandler<E>
            where E : struct, IWfEvent<E> { }
    }
}