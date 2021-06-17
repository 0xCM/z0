//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock2<T> : IDataBlock<DataBlock2<T>>
        where T : unmanaged
    {
        DataBlock1<T> A;

        DataBlock1<T> B;
    }
}