//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {
        [Free]
        public interface IBlockedProjector8<S,T> : IBlockedFunc<W8,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            void Invoke(in SpanBlock8<S> a, in SpanBlock8<T> dst);
        }

        [Free]
        public interface IBlockedProjector16<S,T> : IBlockedFunc<W16,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            void Invoke(in SpanBlock16<S> a, in SpanBlock16<T> dst);
        }

        [Free]
        public interface IBlockedProjector32<S,T> : IBlockedFunc<W32,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            void Invoke(in SpanBlock32<S> a, in SpanBlock32<T> dst);
        }

        [Free]
        public interface IBlockedProjector64<S,T> : IBlockedFunc<W64,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            void Invoke(in SpanBlock64<S> a, in SpanBlock64<T> dst);
        }


        [Free]
        public interface IBlockedProjector128<S,T> : IBlockedFunc<W128,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            void Invoke(in SpanBlock128<S> a, in SpanBlock128<T> dst);
        }

        [Free]
        public interface IBlockedProjector256<S,T> : IBlockedFunc<W256,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            void Invoke(in SpanBlock256<S> a, in SpanBlock256<T> dst);
        }

        [Free]
        public interface IBlockedProjector512<S,T> : IBlockedFunc<W512,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            void Invoke(in SpanBlock512<S> a, in SpanBlock512<T> dst);
        }

    }
}