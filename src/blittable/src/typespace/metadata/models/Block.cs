//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types.metadata
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Z0.Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Block
    {
        public uint CellSize;

        public uint CellCount;

        [MethodImpl(Inline)]
        public Block(uint s, uint n)
        {
            CellSize = s;
            CellCount = n;
        }
    }
}