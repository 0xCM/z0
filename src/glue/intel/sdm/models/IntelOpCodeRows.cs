//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static core;
    using static Root;

    using static IntelSdm;

    [ApiHost]
    public readonly struct IntelOpCodeRows
    {
        [Op]
        public ref OpCodeRow row(TableVariation v, ReadOnlySpan<string> src, out OpCodeRow dst)
        {
            var i=0;
            dst.OpCode = skip(src,i++);
            dst.Instruction = skip(src,i++);
            dst.Encoding = skip(src,i++);
            dst.Mode64 = skip(src,i++);
            dst.LegacyMode = skip(src,i++);
            dst.Description = skip(src,i++);
            return ref dst;
        }

        /// <summary>
        /// | Opcode  | Instruction | Op/En | 64-Bit Mode | Compat/Leg Mode | Description
        /// </summary>
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct OpCodeRow
        {
            public const string TableId = "intel.opcodes";

            public static N1 RowKind => default;

            public string OpCode;

            public string Instruction;

            public string Encoding;

            public string Mode64;

            public string LegacyMode;

            public string Description;
        }
    }
}