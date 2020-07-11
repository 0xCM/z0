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


    public class InstructionIndex
    {
        public IEnumerable<LocatedInstruction> All => Data.Values;

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
        
        public static InstructionIndex Create(LocatedInstruction[] src)
        {
            var index = new Dictionary<MemoryAddress, LocatedInstruction>(src.Length);
            var fail = 0;
            var success = 0;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var inxs = ref src[i];
                if(index.TryAdd(inxs.IP, inxs))
                    success++;
                else
                    fail++;
            }

            term.magenta($"From {src.Length} instructions, {success} were uniquely identified, {fail} were not");
            return new InstructionIndex(index);
        }

        InstructionIndex(Dictionary<MemoryAddress, LocatedInstruction> data)
        {
            Data = data;
        }

        Dictionary<MemoryAddress, LocatedInstruction> Data {get;}        
    }
}