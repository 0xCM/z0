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
        /// <summary>
        /// Defines a 64-bit argument
        /// </summary>
        public readonly struct Arg64 : IOperand<Arg64,W64,ulong>
        {
            public ulong Value {get;}

            [MethodImpl(Inline)]
            public Arg64(ulong value)
            {
                Value = value;
            }

            public OperandSize Width => OperandSize.W64;
        }
    }
}