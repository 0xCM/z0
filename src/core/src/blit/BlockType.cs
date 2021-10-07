//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct BlockType
    {
        public readonly CellType CellType;

        public readonly uint CellCount;

        [MethodImpl(Inline)]
        public BlockType(CellType ct, uint count)
        {
            CellCount = count;
            CellType = ct;
        }
    }
}