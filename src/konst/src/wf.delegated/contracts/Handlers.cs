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
        public interface IHandler<T>
        {
            void Accept(in T src);
        }

        [SuppressUnmanagedCodeSecurity]
        public delegate void Handler<T>(in T src);
    }
}