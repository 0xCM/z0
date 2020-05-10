//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class InstructionModels
    {
        public readonly struct Reg8 : IRegister8<Reg8>
        {
            public byte Value {get;}

            public RegisterKind RegisterKind {get;}
            
            public RegisterSymbol Symbol {get => (RegisterSymbol)RegisterKind; }
        }
    }
}