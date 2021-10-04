//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public static string format(in Var src)
            => string.Format("var({0})", src.Name);

        public static string format<T>(in Var<T> src)
            => string.Format("var<{0}>({1})", typeof(T).Name, src.Name);

        public static string format<T>(in Binding<T> src)
            => string.Format("{0} := {1}", src.Var, src.Value);

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

        public static string format(Grammar src)
        {
            var dst = text.buffer();
            dst.AppendLineFormat("{0} = {1}", src.Name, Chars.LBrace);
            foreach(var p in src.Productions)
                dst.IndentLine(2, format(p));
            dst.AppendLine(Chars.RBrace);
            return dst.Emit();
        }

        public static string format(in Adjacent src)
            => string.Format(RP.Adjacent2,src.A, src.B);

        public static string format<T>(in Adjacent<T> src)
            => string.Format(RP.Adjacent2,src.A, src.B);
    }
}