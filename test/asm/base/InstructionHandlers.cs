//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    using K = Kinds;

    public readonly struct InstructionHandlers
    {
        public static InstructionHandlers Default => new InstructionHandlers(null);
        
        public readonly uint[] Activations;

        readonly int BufferLength;

        readonly Dictionary<Mnemonic, InstructionCollector> Collectors;

        [MethodImpl(Inline)]
        InstructionHandlers(int? count)
        {
            BufferLength = count ??(int)Mnemonic.LAST + 1;
            Activations = new uint[BufferLength];
            Collectors = new Dictionary<Mnemonic, InstructionCollector>();
        }

        [MethodImpl(Inline)]
        ref readonly Instruction Collect(in Instruction i)
        {
            if(Collectors.TryGetValue(i.Mnemonic, out var collector))
                collector.Collect(i);
            else
                Collectors[i.Mnemonic] = InstructionCollector.Create(i);

            Activations[(int)i.Mnemonic]++;

            return ref i;
        }
        
        [MethodImpl(Inline)]
        public void OnVinserti128(in Instruction i)
            => Collect(i);

        [MethodImpl(Inline)]
        public void OnVmovupd(in Instruction i)
            => Collect(i);

        [MethodImpl(Inline)]
        public void OnCall(in Instruction i)
            => Collect(i);        

        public Dictionary<Mnemonic, Instruction[]> Handled
        {
            get => Collectors.Select(kvp => (kvp.Key, kvp.Value.Collected())).ToDictionary();
        }
    }
}