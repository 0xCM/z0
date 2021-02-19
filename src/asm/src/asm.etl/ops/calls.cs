//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct AsmEtl
    {
        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        static ApiInstructions filter(ApiInstructions src, IceMnemonic mnemonic)
            => from a in src.Storage
                let i = a.Instruction
                where i.Mnemonic == mnemonic
                select a;

        /// <summary>
        /// Summarizes a collection of far-call datapoints
        /// </summary>
        /// <param name="targets">The call target addresses</param>
        /// <param name="bases">The base addresses of the callers</param>
        /// <param name="hosted">Base addresses of api host functions that are targets of a far call</param>
        /// <param name="unhosted">Far call targets that are not defined by an api host</param>
        [MethodImpl(Inline), Op]
        public static AsmCallSummary farcalls(Index<MemoryAddress> targets, Index<MemoryAddress> bases, Index<MemoryAddress> hosted, Index<MemoryAddress> unhosted)
            => new AsmCallSummary(targets, bases, hosted, unhosted);

        [Op]
        public static Index<AsmCallRow> calls(ApiInstructions src)
        {
            var calls = filter(src, IceMnemonic.Call).View;
            var count = calls.Length;
            var buffer = alloc<AsmCallRow>(count);
            ref var row = ref first(span(buffer));
            for(var i=0u; i<count; i++)
            {
                ref readonly var call = ref skip(calls,i);
                ref var dst = ref seek(row,i);
                var bytes = span(call.EncodedData.Storage);
                var offset = ByteReader.read(bytes.Slice(1));
                var target = call.NextIp + offset;
                dst.Source = call.IP;
                dst.Target = target;
                dst.InstructionSize = call.ByteLength;
                dst.TargetOffset = target - (call.IP + src.Length);
                dst.Instruction = call.FormattedInstruction;
                dst.Encoded = call.Encoded.Storage;
            }
            return buffer;
        }
    }
}