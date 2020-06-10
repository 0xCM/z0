//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    public readonly struct InstructionCollector
    {
        readonly List<Instruction> items;

        [MethodImpl(Inline)]
        public static InstructionCollector Create(params Instruction[] src)
            => new InstructionCollector(src);
        
        [MethodImpl(Inline)]
        InstructionCollector(params Instruction[] src)
        {
            items = new List<Instruction>();
            items.AddRange(src);
        }

        [MethodImpl(Inline)]
        public void Collect(in Instruction src)
            => items.Add(src);

        [MethodImpl(Inline)]
        public void Collect(IEnumerable<Instruction> src)
            => items.AddRange(src);
        

        [MethodImpl(Inline)]
        public Instruction[] Collected()
            => items.ToArray();
    }

}