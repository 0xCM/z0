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

    public class AsmFxHandlers
    {
        public readonly uint[] Activations;

        readonly int BufferLength;

        readonly Dictionary<IceMnemonic, AsmFxSink> Sinks;

        readonly Dictionary<IceMnemonic, AsmFxCollector> Collectors;

        [MethodImpl(Inline)]
        public AsmFxHandlers()
        {
            BufferLength = (int)IceMnemonic.LAST + 1;
            Activations = new uint[BufferLength];
            Sinks = new Dictionary<IceMnemonic, AsmFxSink>();
            Collectors = new Dictionary<IceMnemonic, AsmFxCollector>();
        }

        [MethodImpl(Inline)]
        ref readonly Instruction Collect(in Instruction src)
        {
            if(Collectors.TryGetValue(src.Mnemonic, out var collector))
                collector.Collect(src);
            else
                Collectors[src.Mnemonic] = asm.collector(src);

            if(Sinks.TryGetValue(src.Mnemonic, out var sink))
                sink.Deposit(src);

            Activations[(int)src.Mnemonic]++;

            return ref src;
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

        public Dictionary<IceMnemonic,Instruction[]> Handled
        {
            get => Collectors.Select(kvp => (kvp.Key, kvp.Value.Collected())).ToDictionary();
        }

        public static AsmFxHandlers Default
            => new AsmFxHandlers();
    }
}