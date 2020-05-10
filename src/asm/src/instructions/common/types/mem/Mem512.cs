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
        public readonly struct Mem512 : IMemory512<Mem512>
        {
            public Vector512<byte> Value {get;}

            public OperandSize Width => OperandSize.W512;
        }
    }
}