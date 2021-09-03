//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock11<T> : IDataBlock<GBlock11<T>>
        where T : unmanaged
    {
        GBlock10<T> A;

        GBlock1<T> B;
    }
}