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

    using static TextRules.Format;

    partial struct AsmCases
    {
        [Op]
        public static string format(in CallRel32Case src)
        {
            var dst = text.buffer();
            dst.AppendPropLine(property(nameof(src.Caller), src.Caller.Format()));
            dst.AppendPropLine(property(nameof(src.Ip), src.Ip.Format()));
            dst.AppendPropLine(property(nameof(src.NextIp), src.NextIp.Format()));
            dst.AppendPropLine(property(nameof(src.Target), src.Target.Format()));
            dst.AppendPropLine(property(nameof(src.RelTarget), src.RelTarget.Format()));
            dst.AppendPropLine(property(nameof(src.Encoding), src.Encoding.FormatAsmHex()));
            return dst.Emit();
        }
    }
}