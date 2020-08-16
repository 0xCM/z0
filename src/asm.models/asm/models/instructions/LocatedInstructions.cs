//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;

    public readonly struct LocatedInstructions
    {
        public readonly LocatedAsmFx[] Indexed;

        readonly Dictionary<MemoryAddress, LocatedAsmFx> Index;
        
        public static LocatedInstructions create(LocatedAsmFx[] src)
        {
            var count = src.Length;
            var index = new Dictionary<MemoryAddress, LocatedAsmFx>(count);
            var fail = 0;
            var success = 0;
            var source = sys.span(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var located = ref z.skip(source,i);
                if(index.TryAdd(located.IP, located))
                    success++;
                else
                    fail++;
            }

            term.magenta($"From {src.Length} instructions, {success} were uniquely identified, {fail} were not");
            return new LocatedInstructions(src, index);
        }
        
        public IEnumerable<LocatedAsmFx> All 
            => Index.Values;

        public IEnumerable<LocatedAsmFx> Calls 
            => from a in All
                let i = a.Instruction
                where i.Mnemonic == Mnemonic.Call
                select a;
        public IEnumerable<AspectData<IAsmCallInfo>> CallData
            => from c in CallInfo
                let values = c.AspectValues
                select new AspectData<IAsmCallInfo>(c, c.AspectValues.ToArray());

        public IEnumerable<AsmCallInfo> CallInfo 
            => Calls.Select(x => new AsmCallInfo(x)).Where(x => !x.Target.IsEmpty).OrderBy(x => x.TargetOffset);
        
        [MethodImpl(Inline)]
        internal LocatedInstructions(LocatedAsmFx[] indexed,  Dictionary<MemoryAddress, LocatedAsmFx> index)
        {
            Indexed = indexed;
            Index = index;
        }        
    }
}