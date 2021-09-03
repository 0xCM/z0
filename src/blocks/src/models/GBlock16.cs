//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock16<T> : IDataBlock<GBlock16<T>>
        where T : unmanaged
    {
        GBlock8<T> A;

        GBlock8<T> B;
    }
}