//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;
    partial struct Rules
    {
        [Op, Closures(Closure)]
        public static string format<T>(in CmpPred<T> src)
            => string.Format("{0}{1}{2}", src.A, symbol(src.Kind), src.B);

        [Op, Closures(Closure)]
        public static string format<T>(in CmpEval<T> src)
            => string.Format("{0}:{1}", format(src.Source), src.Result ? "true" : "false");

        public static string format<F,C>(Enclosed<F,C> rule)
        {
            var buffer = TextTools.buffer();
            render(rule,buffer);
            return buffer.Emit();
        }

        public static string format<T>(in Union<T> src)
        {
            var dst = text.buffer();
            var members = src.Members;
            var count = members.Length;
            dst.Append(src.Name);
            if(count != 0)
                dst.Append(" = ");

            for(var i=0; i<count; i++)
            {
                if(i != count - 1)
                    dst.Append(string.Format("{0} | ",skip(members,i)));
                else
                    dst.Append(string.Format("{0}", skip(members,i)));
            }
            return dst.Emit();
        }

        public static void render<F,C>(Enclosed<F,C> rule, ITextBuffer dst)
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

        [Op]
        public static string format(VarSymbol src)
            => format(VarContextKind.Workflow, src);

        [Op, Closures(Closure)]
        public static string format<T>(VarSymbol<T> src)
            => format(VarContextKind.Workflow, src);

        [Op, Closures(Closure)]
        public static string format<T>(VarContextKind vck, VarSymbol<T> src)
            => string.Format(VarContextKinds.FormatPattern(vck), src.Name);

        [Op]
        public static string format(VarContextKind vck, VarSymbol src)
            => string.Format(VarContextKinds.FormatPattern(vck), src.Name);
    }
}