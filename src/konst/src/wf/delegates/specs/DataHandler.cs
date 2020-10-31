//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct WfDelegates
    {
        [Free]
        public delegate void DataHandler<T>(in T src)
            where T : struct;
    }
}