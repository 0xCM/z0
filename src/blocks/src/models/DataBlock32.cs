//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock32<T> : IStorageBlock<DataBlock32<T>>
        where T : unmanaged
    {
        DataBlock16<T> A;

        DataBlock16<T> B;
    }
}