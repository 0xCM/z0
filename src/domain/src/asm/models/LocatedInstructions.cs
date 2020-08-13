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
        public readonly LocatedInstruction[] Indexed;

        readonly Dictionary<MemoryAddress, LocatedInstruction> Index;
        
        public static LocatedInstructions create(LocatedInstruction[] src)
        {
            var count = src.Length;
            var index = new Dictionary<MemoryAddress, LocatedInstruction>(count);
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
        
        public IEnumerable<LocatedInstruction> All 
            => Index.Values;

        public IEnumerable<LocatedInstruction> Calls 
            => from a in All
                let i = a.Instruction
                where i.Mnemonic == Mnemonic.Call
                select a;
        public IEnumerable<AspectData<ICallInfo>> CallData
            => from c in CallInfo
                let values = c.AspectValues
                select new AspectData<ICallInfo>(c, c.AspectValues.ToArray());

        public IEnumerable<CallInfo> CallInfo 
            => Calls.Select(x => new CallInfo(x)).Where(x => !x.Target.IsEmpty).OrderBy(x => x.TargetOffset);
        
        [MethodImpl(Inline)]
        internal LocatedInstructions(LocatedInstruction[] indexed,  Dictionary<MemoryAddress, LocatedInstruction> index)
        {
            Indexed = indexed;
            Index = index;
        }        
    }
}