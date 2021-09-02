//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock3<T> : IStorageBlock<DataBlock3<T>>
        where T : unmanaged
    {
        DataBlock1<T> A;

        DataBlock2<T> B;
    }
}