//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct BlockMoniker
    {        
        public static BlockMoniker Define(BlockWidth width, PrimalKind cellkind)
            => new BlockMoniker(width,cellkind);

        public BlockMoniker(BlockWidth width, PrimalKind cellkind)
        {
            this.BlockWidth = width;
            this.CellKind = cellkind;
        }
        
        public readonly BlockWidth BlockWidth;

        public readonly PrimalKind CellKind;

        public string Format()
            => $"{(uint)BlockWidth}x{CellKind.Format()}";
        
        public override string ToString() 
            => Format();
    }
}