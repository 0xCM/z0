//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;
    using static core;

    partial struct Rules
    {
        public static string format(in Var src)
            => string.Format("var({0})", src.Name);

        public static string format<T>(in Var<T> src)
            where T : ITerm<T>
                => string.Format("var<{0}>({1})", typeof(T).Name, src.Name);

        public static string format<T>(in VarBinding<T> src)
            where T : ITerm<T>
                => string.Format("{0} := {1}", src.Var, src.Term);

        public static string format<T>(in Replace<T> src)
            => string.Format("replace<{0}>({1} -> {2})", typeof(T).Name, src.Match, src.Value);

        public static string format(in StringLiteral src)
            => string.Format("{0} := '{1}'", src.Name, src.Value);

        public static string format<T>(in Constant<T> src)
            => src.Value?.ToString() ?? EmptyString;

        public static string format<T>(in Literal<T> src)
            => string.Format("{0} := {1}", src.Name, src.Value);

        public static string format(in OneOf src)
        {
            var terms = src.Terms;
            var count = terms.Length;
            var dst = text.buffer();

            for(var i=0; i<count; i++)
            {
                ref readonly var term = ref terms[i];
                if(term is IProduction p)
                    dst.Append(string.Format("<{0}>", p.Name));
                else
                    dst.Append(term.ToString());

                if(i != count -1)
                    dst.Append(" | ");
            }
            return dst.Emit();
        }

        public static string format(IProduction src)
        {
            var dst = text.buffer();
            dst.AppendFormat("<{0}> := {1}", src.Name, format(src.Expansion));
            return dst.Emit();
        }

        public static string format<T>(in Atom<T> src)
            where T : unmanaged
                => src.Value.ToString();

        public static string format<T>(in Range<T> src)
            where T : unmanaged, IEquatable<T>, IComparable<T>
                => string.Format("[{0}..{1}]", src.Min, src.Max);

        public static string format<T>(in Between<T> src)
            where T : unmanaged, IEquatable<T>, IComparable<T>
                => string.Format("[{0}, {1}]", src.Min, src.Max);

        public static string format<T>(in Rule<T> src)
            where T : ITerm<T>
                => string.Format("{0} := {1}", src.Name, src.Term.Format());

        public static string format<K,T>(in Switch<K,T> src)
            where T : ITerm<T>
            where K : unmanaged
        {
            var dst = text.buffer();
            var margin = 0u;
            var choices = src.Choices;
            var terms = src.Terms;
            var count = choices.Length;
            dst.IndentLineFormat(margin, "switch({0}) {", src.Name);
            margin += 2;
            for(var i=0; i<count; i++)
            {
                ref readonly var choice = ref skip(choices,i);
                ref readonly var term = ref skip(terms,i);
                dst.IndentLineFormat(margin, "{0} -> {1}", choice.Format(), term.Format());
            }
            margin -=2;
            dst.IndentLine(margin, "}");

            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string format<T>(in CmpPred<T> src)
            => string.Format("{0}{1}{2}", src.A, symbol(src.Kind), src.B);

        [Op, Closures(Closure)]
        public static string format<T>(in CmpEval<T> src)
            => string.Format("{0}:{1}", format(src.Source), src.Result ? "true" : "false");
    }
}