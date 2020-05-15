//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class Commands
    {
        public readonly struct Reg16 : IRegister16<Reg16>
        {
            public ushort Value {get;}

            public RegisterKind RegisterKind {get;}

            public RegisterSymbol Symbol {get => (RegisterSymbol)RegisterKind; }

        }
    }
}