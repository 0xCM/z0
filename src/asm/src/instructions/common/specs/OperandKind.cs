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
    using static Memories;

    partial class InstructionModels
    {
        [Flags]
        public enum OperandKind : byte
        {
            None =0,

            Register = 1,

            Memory = 2,

            Imm = 4,
        }
    }
}