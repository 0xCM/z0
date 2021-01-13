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

    public readonly struct IceInstructionCollector
    {
        readonly List<IceInstruction> items;

        [MethodImpl(Inline)]
        public IceInstructionCollector(params IceInstruction[] fx)
        {
            items = new List<IceInstruction>();
            items.AddRange(fx);
        }

        [MethodImpl(Inline)]
        public void Collect(in IceInstruction src)
            => items.Add(src);

        [MethodImpl(Inline)]
        public void Collect(IEnumerable<IceInstruction> src)
            => items.AddRange(src);

        [MethodImpl(Inline)]
        public IceInstruction[] Collected()
            => items.ToArray();
    }
}