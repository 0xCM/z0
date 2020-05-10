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
        /// Defines a 256-bit argument
        /// </summary>
        public readonly struct Arg256: IOperand<Arg256,W256,Vector256<byte>>
        {
            public Vector256<byte> Value {get;}

            [MethodImpl(Inline)]
            public Arg256(Vector256<byte> value)
            {
                Value = value;
            }

            public OperandSize Width => OperandSize.W256;

        }
    }
}