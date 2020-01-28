//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct BlockSig
    {        
        public static BlockSig Define(BlockWidth width, NumericKind cellkind)
            => new BlockSig(width,cellkind);

        public BlockSig(BlockWidth width, NumericKind cellkind)
        {
            this.BlockWidth = width;
            this.CellKind = cellkind;
        }
        
        public readonly BlockWidth BlockWidth;

        public readonly NumericKind CellKind;

        public string Format()
            => $"{(uint)BlockWidth}x{CellKind.Format()}";
        
        public override string ToString() 
            => Format();
    }
}