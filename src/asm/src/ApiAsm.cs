//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    public readonly struct ApiAsm
    {
        public static ApiInstruction[] CallInstructions(ApiInstructions src)
            => from a in src.All
                let i = a.Instruction
                where i.Mnemonic == Mnemonic.Call
                select a;

        public static MachineCallInfo[] MachineCalls(ApiInstructions src)
            => CallInstructions(src).Select(x => new MachineCallInfo(x)).Where(x => !x.Target.IsEmpty).OrderBy(x => x.TargetOffset).Array();

        public static AsmCallRow[] CallRecords(ApiInstructions src)
        {
            var calls = @readonly(MachineCalls(src));
            var count = calls.Length;
            var buffer = alloc<AsmCallRow>(count);
            ref var dst = ref first(span(buffer));
            for(var i=0u; i<count; i++)
                skip(calls,i).Fill(ref seek(dst,i));
            return buffer;
        }
    }
}