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
        /// Defines a 128-bit argument
        /// </summary>
        public readonly struct Arg128: IOperand<Arg128,W128,Vector128<byte>>
        {
            public Vector128<byte> Value {get;}

            [MethodImpl(Inline)]
            public Arg128(Vector128<byte> value)
            {
                Value = value;
            }

            public OperandSize Width => OperandSize.W128;
        }
    }
}