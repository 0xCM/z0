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
            var dst = text.buffer();
            dst.AppendLine(src.AsmSource);
            dst.AppendLine(text.prop(nameof(src.Caller), AsmRender.format(src.Caller)));
            dst.AppendLine(text.prop(nameof(src.Ip), src.Ip.Format()));
            dst.AppendLine(text.prop(nameof(src.NextIp), src.NextIp.Format()));
            dst.AppendLine(text.prop(nameof(src.Target), src.Target.Format()));
            dst.AppendLine(text.prop(nameof(src.RelTarget), src.RelTarget.Format()));
            dst.AppendLine(text.prop(nameof(src.Encoding), src.Encoding.Format()));
            return dst.Emit();
        }
    }
}