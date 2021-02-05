//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IBitLogic<T> : IUnaryBitLogic<T>, IBinaryBitLogic<T>, ITernaryBitLogic<T>
    {

    }
}