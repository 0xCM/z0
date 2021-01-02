//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public readonly struct AsmFxCollector
    {
        readonly List<Instruction> items;

        [MethodImpl(Inline)]
        public AsmFxCollector(params Instruction[] fx)
        {
            items = new List<Instruction>();
            items.AddRange(fx);
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