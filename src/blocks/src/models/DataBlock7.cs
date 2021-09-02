//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock7<T> : IStorageBlock<DataBlock6<T>>
        where T : unmanaged
    {
        DataBlock6<T> A;

        DataBlock1<T> B;
    }
}