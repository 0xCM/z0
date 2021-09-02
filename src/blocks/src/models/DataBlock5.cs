//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock5<T> : IStorageBlock<DataBlock5<T>>
        where T : unmanaged
    {
        DataBlock4<T> A;

        DataBlock1<T> B;
    }
}