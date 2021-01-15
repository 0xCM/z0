//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static z;
    using static Part;

    partial struct asm
    {
        public static AsmCallRow[] calls(ApiInstructionBlock src)
        {
            var calls = asm.filter(src, IceMnemonic.Call).View;
            var count = calls.Length;
            var buffer = alloc<AsmCallRow>(count);
            ref var row = ref first(span(buffer));
            for(var i=0u; i<count; i++)
            {
                ref readonly var call = ref skip(calls,i);
                ref var dst = ref seek(row,i);
                var bytes = span(call.EncodedData.Storage);
                var offset = ByteReader.read(bytes.Slice(1));// + ((uint)bytes.Length - 1); //op code takes up one byte
                var target = call.NextIp + offset;
                dst.Source = call.IP;
                dst.Target = target;
                dst.InstructionSize = call.Size;
                dst.TargetOffset = target - (call.IP + src.Length);
                dst.Instruction = call.FormattedInstruction;
                dst.Encoded = call.Encoded.Storage;
            }
            return buffer;
        }

        /// <summary>
        /// Selects a (non-distinct) sequence of far addresses that are target by call instructions in the source function
        /// </summary>
        /// <param name="src">The source functions</param>
        public static MemoryAddress[] CallAddresses(AsmRoutine src)
            => (from i in src.Instructions
                where i.FlowControl == IceFlowControl.Call
                    select (MemoryAddress)i.MemoryAddress64).Array();

        /// <summary>
        /// Selects a (non-distinct) sequence of addresses targeted by functions in the source
        /// </summary>
        /// <param name="src">The source functions</param>
        public static MemoryAddress[] CallAddresses(AsmRoutines src)
            => src.Data.SelectMany(CallAddresses).Array();
    }
}