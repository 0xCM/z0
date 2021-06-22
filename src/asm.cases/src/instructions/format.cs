//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCases
    {
        [Op]
        public static string format(in CallRel32Case src)
        {
            var dst = TextTools.buffer();
            dst.AppendLine(src.AsmSource);
            dst.AppendLine(TextProp.define(nameof(src.Caller), AsmRender.format(src.Caller)));
            dst.AppendLine(TextProp.define(nameof(src.Ip), src.Ip.Format()));
            dst.AppendLine(TextProp.define(nameof(src.NextIp), src.NextIp.Format()));
            dst.AppendLine(TextProp.define(nameof(src.Target), src.Target.Format()));
            dst.AppendLine(TextProp.define(nameof(src.RelTarget), src.RelTarget.Format()));
            dst.AppendLine(TextProp.define(nameof(src.Encoding), src.Encoding.Format()));
            return dst.Emit();
        }
    }
}