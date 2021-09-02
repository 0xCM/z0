//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock12<T> : IStorageBlock<DataBlock12<T>>
        where T : unmanaged
    {
        DataBlock6<T> A;

        DataBlock6<T> B;
    }
}