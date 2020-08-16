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

    public readonly struct AsmFxHandlers
    {
        public readonly uint[] Activations;

        readonly int BufferLength;

        readonly Dictionary<Mnemonic, AsmFxSink> Sinks;

        readonly Dictionary<Mnemonic, AsmFxCollector> Collectors;

        [MethodImpl(Inline)]
        internal AsmFxHandlers(int? count)
        {
            BufferLength = count ??(int)Mnemonic.LAST + 1;
            Activations = new uint[BufferLength];
            Sinks = new Dictionary<Mnemonic, AsmFxSink>();
            Collectors = new Dictionary<Mnemonic, AsmFxCollector>();
        }

        [MethodImpl(Inline)]
        ref readonly Instruction Collect(in Instruction i)
        {
            if(Collectors.TryGetValue(i.Mnemonic, out var collector))
                collector.Collect(i);
            else
                Collectors[i.Mnemonic] = asm.collector(i);

            if(Sinks.TryGetValue(i.Mnemonic, out var sink))
                sink.Deposit(i);            

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

        [MethodImpl(Inline)]
        public bool Include(AsmFxSink sink)
            => Sinks.TryAdd(sink.Kind, sink);

        public Dictionary<Mnemonic,Instruction[]> Handled
        {
            get => Collectors.Select(kvp => (kvp.Key, kvp.Value.Collected())).ToDictionary();
        }

        public static AsmFxHandlers Default 
            => new AsmFxHandlers(null);        
    }
}