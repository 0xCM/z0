//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBitLogicHost<H,T> : IBinaryBitLogic<T>
        where H : struct, IBitLogicHost<H,T>
        where T : struct
    {

    }
}