//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock4<T> : IStorageBlock<DataBlock4<T>>
        where T : unmanaged
    {
        DataBlock2<T> A;

        DataBlock2<T> B;
    }
}