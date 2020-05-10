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
        /// Defines a 16-bit argument
        /// </summary>
        public readonly struct Arg16 : IOperand<Arg16,W16,ushort>
        {
            public ushort Value {get;}

            [MethodImpl(Inline)]
            public Arg16(ushort value)
            {
                Value = value;
            }

            public OperandSize Width => OperandSize.W16;

        }
    }
}