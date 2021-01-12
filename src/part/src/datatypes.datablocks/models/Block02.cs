//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct DataBlocks
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Block02<T>
            where T : unmanaged
        {
            Block01<T> Block0;

            Block01<T> Block1;
        }
    }
}