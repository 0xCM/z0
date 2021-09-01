//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmForm form(in AsmSig sig, in AsmOpCode oc)
            => new AsmForm(sig, oc);

        /// <summary>
        /// Distills <see cref='AsmForm'/> values from a <see cref='SdmOpCodeDetail'/> sequence
        /// </summary>
        /// <param name="src">The data source</param>
        [Op]
        public static Index<AsmForm> forms(ReadOnlySpan<SdmOpCodeDetail> src)
        {
            var count = src.Length;
            var buffer = alloc<AsmForm>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                ref var opcode = ref SdmModels.opcode(record, out _);
                ref var current = ref seek(dst,i);
                current = form(
                    sig(opcode.Mnemonic.Format(), SdmModels.operands(opcode)),
                    asm.opcode((ushort)opcode.OpCodeId, opcode.Expr)
                    );
            }
            return buffer;
        }
    }
}