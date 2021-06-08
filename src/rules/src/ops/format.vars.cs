//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        public static string format<F,C>(Fenced<F,C> rule)
        {
            var buffer = TextTools.buffer();
            render(rule,buffer);
            return buffer.Emit();
        }

        public static void render<F,C>(Fenced<F,C> rule, ITextBuffer dst)
            => dst.AppendFormat("{0}{1}{2}", rule.Fence.Left, rule.Content, rule.Fence.Right);

        [Op]
        public static string format(IVar var, char assign)
            => string.Format("{0}{1}{2}", format(var.Symbol), assign, var.Value);

        [Op]
        public static string format(IVar var)
            => format(var, Chars.Eq);

        [Op]
        public static string format(VarContextKind vck, IVar var, char assign)
            => string.Format("{0}{1}{2}", format(vck, var.Symbol), assign, var.Value);

        [Op]
        public static string format(VarContextKind vck, IVar var)
            => format(vck,var, Chars.Eq);
    }
}