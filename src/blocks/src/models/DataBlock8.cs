//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct DataBlock8<T> : IDataBlock<DataBlock8<T>>
        where T : unmanaged
    {
        DataBlock4<T> A;

        DataBlock4<T> B;
    }
}