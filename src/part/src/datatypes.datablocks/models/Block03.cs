//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    public readonly partial struct DataBlocks
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Block03<T>
            where T : unmanaged
        {
            Block01<T> Block0;

            Block02<T> Block1;
        }
    }
}