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
        /// Defines a 512-bit argument
        /// </summary>
        public readonly struct Arg512: IOperand<Arg512,W512,Vector512<byte>>
        {
            public Vector512<byte> Value {get;}

            public Arg512(Vector512<byte> value)
            {
                Value = value;
            }

            public OperandSize Width => OperandSize.W512;
        }
    }
}