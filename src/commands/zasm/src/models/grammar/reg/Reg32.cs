//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;

    partial class Commands
    {
        public readonly struct Reg32 : IRegister32<Reg32>
        {
            public uint Value {get;}

            public RegisterKind RegisterKind {get;}

            public RegisterSymbol Symbol {get => (RegisterSymbol)RegisterKind; }
        }
    }
}