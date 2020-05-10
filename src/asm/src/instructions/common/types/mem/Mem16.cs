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
        public readonly struct Mem16 : IMemory16<Mem16>
        {
            public ushort Value {get;}

            public OperandSize Width => OperandSize.W16;

        }
    }
}