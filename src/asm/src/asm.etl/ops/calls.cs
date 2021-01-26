//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static z;

    partial struct AsmEtl
    {
        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        static ApiInstructionBlock filter(ApiInstructionBlock src, IceMnemonic mnemonic)
            => from a in src.All
                let i = a.Instruction
                where i.Mnemonic == mnemonic
                select a;

        [Op]
        public static AsmCallRow[] calls(ApiInstructionBlock src)
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
                dst.InstructionSize = call.Size;
                dst.TargetOffset = target - (call.IP + src.Length);
                dst.Instruction = call.FormattedInstruction;
                dst.Encoded = call.Encoded.Storage;
            }
            return buffer;
        }
    }
}