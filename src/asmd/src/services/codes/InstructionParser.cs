//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    readonly struct InstructionParser
    {
        public static InstructionParser Service => default(InstructionParser);

        public InstructionSpec Parse(InstructionExpression src)            
        {

            return new InstructionSpec(src);
        }
    }
}