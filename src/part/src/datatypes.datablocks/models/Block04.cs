//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct DataBlocks
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Block04<T>
            where T : unmanaged
        {
            Block02<T> Cell0;

            Block02<T> Cell1;
        }
    }
}