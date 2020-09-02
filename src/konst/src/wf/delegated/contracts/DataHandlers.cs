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
        public delegate void DataHandler(IDataEvent e);

        [SuppressUnmanagedCodeSecurity]
        public delegate void DataHandler<T>(in T src)
            where T : struct, IDataEvent<T>;

        public interface IDataHandler
        {
            void Accept(IDataEvent src);
        }

        [SuppressUnmanagedCodeSecurity]
        public interface IDataHandler<T> : IDataHandler
            where T : struct, IDataEvent<T>
        {
            void Accept(in T src);

            void IDataHandler.Accept(IDataEvent src)
                => Accept((T)src);
        }
    }
}