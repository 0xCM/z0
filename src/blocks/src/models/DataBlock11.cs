//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock11<T> : IDataBlock<DataBlock11<T>>
        where T : unmanaged
    {
        DataBlock10<T> A;

        DataBlock1<T> B;
    }
}