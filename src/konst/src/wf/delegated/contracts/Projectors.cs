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
        public delegate T Projector<S,T>(in S src);

        [SuppressUnmanagedCodeSecurity]
        public delegate T TableProjector<S,T>(in S src)
            where S : struct;


        [SuppressUnmanagedCodeSecurity]
        public interface IProjector<S,T>
        {
            T Map(in S src);
        }

        [SuppressUnmanagedCodeSecurity]
        public interface ITableProjector<S,T> : IProjector<S,T>
            where S : struct
        {

        }
    }
}