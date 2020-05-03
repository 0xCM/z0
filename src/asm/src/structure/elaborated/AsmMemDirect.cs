//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmMemDirect
    {
        public AsmMemDirect(Register register, uint dx, int dxSize, int scale)
        {
            this.BaseRegister = register;
            this.Displacement = dx;
            this.DisplacementSize = dxSize;
            this.IndexScale = scale;
        }
        
        public Register BaseRegister {get;}
        
        public uint Displacement {get;}
                
        public int DisplacementSize {get;}

        public int IndexScale {get;}        
    }
}