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
        public readonly struct Reg128 : IRegister128<Reg128>
        {
            public Vector128<byte> Value {get;}

            public RegisterKind RegisterKind {get;}

            public RegisterSymbol Symbol {get => (RegisterSymbol)RegisterKind; }

        }
    }
}