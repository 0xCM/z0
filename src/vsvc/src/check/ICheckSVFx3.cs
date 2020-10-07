//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    [SuppressUnmanagedCodeSecurity]
    public interface ICheckBinarySVFD<W,F,T>
        where T : unmanaged
        where W : ITypeWidth
        where F : IBinaryOp<T>
    {
        void CheckSVF(F f);
    }
}