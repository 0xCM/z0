//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Models
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class Commands
    {
        public readonly struct Reg64 : IRegister64<Reg64>
        {
            public ulong Value {get;}

            public RegisterKind RegisterKind {get;}

            public RegisterSymbol Symbol {get => (RegisterSymbol)RegisterKind; }
        }
    }
}