//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;


    public readonly struct VBlockStats
    {
        [MethodImpl(Inline)]
        public static VBlockStats Calc(int blocks, int blockwidth, int cellwidth)
            => new VBlockStats(blocks, blockwidth, cellwidth);

        [MethodImpl(Inline)]
        public static VBlockStats<T> Calc<T>(int blocks, int blockwidth)
            where T : unmanaged
                => new VBlockStats<T>(blocks, blockwidth);

        [MethodImpl(Inline)]
        public static VBlockStats<N,T> Calc<N,T>(int blocks, N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new VBlockStats<N,T>(blocks);

        [MethodImpl(Inline)]
        public VBlockStats(int blocks, int blockwidth, int cellwidth)
        {
            this.BlockCount = blocks;
            this.BlockWidth = blockwidth;
            this.CellWidth = cellwidth;
            this.BlockLength = BlockWidth / CellWidth;
            this.CellCount = (BlockWidth * BlockCount)/CellWidth;
        }

        public readonly int BlockCount;

        public readonly int BlockWidth;

        public readonly int CellWidth;

        public readonly int BlockLength;

        public readonly int CellCount;
    }

    public readonly struct VBlockStats<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public VBlockStats(int blocks, int blockwidth)
        {
            this.BlockCount = blocks;
            this.BlockWidth = blockwidth;
            this.CellWidth = bitsize<T>();
            var calcs = VBlockStats.Calc(BlockCount, BlockWidth, CellWidth);
            this.BlockLength = calcs.BlockLength;
            this.CellCount = calcs.CellCount;
        }

        public readonly int BlockCount;

        public readonly int BlockWidth;

        public readonly int CellWidth;

        public readonly int BlockLength;

        public readonly int CellCount;
    }

    public readonly struct VBlockStats<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public VBlockStats(int blocks)
        {
            this.BlockCount = blocks;
            this.BlockWidth = natval<N>();
            this.CellWidth = bitsize<T>();
            var calcs = VBlockStats.Calc(BlockCount, BlockWidth, CellWidth);
            this.BlockLength = calcs.BlockLength;
            this.CellCount = calcs.CellCount;
        }

        public readonly int BlockCount;

        public readonly int BlockWidth;

        public readonly int CellWidth;

        public readonly int BlockLength;

        public readonly int CellCount;
    }
}