//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    public readonly struct InstructionFilter
    {        
        readonly InstructionTest F;

        readonly Action<Instruction> Target;

        [MethodImpl(Inline)]
        public static InstructionFilter create(InstructionTest f, Action<Instruction> dst)
            => new InstructionFilter(f, dst);

        [MethodImpl(Inline)]
        public InstructionFilter(InstructionTest f, Action<Instruction> sink)
        {
            F = f;
            Target = sink;
        }

        public void Flow(Instruction[] src)
        {
            ref readonly var next = ref first(span(src));
            for(var i=0; i< src.Length; i++)
            {
                next = ref skip(next, i);
                if(F(next))
                    Target(next);
            }
        }
    }
}