//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock16<T> : IStorageBlock<DataBlock16<T>>
        where T : unmanaged
    {
        DataBlock8<T> A;

        DataBlock8<T> B;
    }
}