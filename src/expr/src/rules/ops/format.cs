//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using static core;
    using static SyntaxPatterns;

    using XF = SyntaxPatterns;

    partial struct rules
    {
        internal static string format<C>(in Test<C> src)
            where C : IExpr
                => string.Format("?({0})", src.Condition);

        internal static string format<A,B>(in Alt<A,B> src)
            => string.Format(XF.BinaryChoice, src.Left, src.Right);

        internal static string format<T>(in Alt<T> src)
            => string.Format(XF.BinaryChoice, src.Left, src.Right);

        internal static string format<T>(in Union<T> src)
        {
            var dst = text.buffer();
            var terms = src.Terms;
            var count = terms.Length;
            dst.Append(XF.ListOpen);

            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(Chars.Space);

                dst.AppendFormat(RP.Slot0, skip(terms,i));

                if(i != count - 1)
                {
                    dst.Append(Chars.Space);
                    dst.Append(XF.Choice);
                }
            }
            dst.Append(XF.ListClose);
            return dst.Emit();
        }

        internal static string format(in Union src)
        {
            var terms = src.Terms;
            var count = terms.Length;
            var dst = text.buffer();

            dst.Append(XF.ListOpen);
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(Chars.Space);

                dst.AppendFormat(RP.Slot0, skip(terms,i));

                if(i != count - 1)
                {
                    dst.Append(Chars.Space);
                    dst.Append(XF.Choice);
                }
            }
            dst.Append(XF.ListClose);

            return dst.Emit();
        }

        internal static string format<T>(in Exclude<T> src)
        {
            var dst = text.buffer();
            var terms = src.Terms;
            var count = terms.Length;
            dst.Append(Chars.Tilde);
            dst.Append(union(src.Storage).Format());
            return dst.Emit();
        }

        internal static string format(in Exclude src)
        {
            var terms = src.Terms;
            var count = terms.Length;
            var dst = text.buffer();

            dst.Append(Chars.Tilde);
            dst.Append(XF.ListClose);
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(Chars.Space);

                dst.AppendFormat(RP.Slot0, skip(terms,i));

                if(i != count - 1)
                {
                    dst.Append(Chars.Space);
                    dst.Append(XF.Choice);
                }
            }
            dst.Append(XF.ListClose);
            return dst.Emit();
        }

        internal static string format<T>(in Between<T> src)
            => string.Format(InclusiveRange, src.Min, src.Max);

        internal static string format<T>(in Rule<T> src)
            where T : IExpr
                => string.Format(Definition, src.Name, src.Expr.Format());

        internal static string format<K,T>(in Branch<K,T> src)
            where T : IExpr
            where K : unmanaged
        {
            var dst = text.buffer();
            var margin = 0u;
            var choices = src.Choices;
            var terms = src.Targets;
            var count = choices.Length;
            dst.IndentLineFormat(margin, "{0}({1}) {", "branch", src.Name);
            margin += 2;
            for(var i=0; i<count; i++)
                dst.IndentLineFormat(margin, XF.BranchCase, skip(choices,i).Format(), skip(terms,i).Format());
            margin -=2;
            dst.IndentLine(margin, "}");

            return dst.Emit();
        }

        internal static string format(in SeqRange src)
            => string.Format(XF.InclusiveRange, src.Min, src.Max);

        internal static string format<T>(in SeqRange<T> src)
            => string.Format(XF.InclusiveRange, src.Min, src.Max);

        internal static string format(in Adjacent src)
            => string.Format(RP.Adjacent2,src.A, src.B);

        internal static string format<T>(in Adjacent<T> src)
            => string.Format(RP.Adjacent2,src.A, src.B);

        internal static string format<T>(in ItemMatch<T> src)
            where T : System.IEquatable<T>
                => string.Format("match({0})", src.Value);

        internal static string format<T>(in Replace<T> src)
            => string.Concat(
                string.Format("replace" + XF.AngledSlot0, typeof(T).Name),
                string.Format(XF.SourceToTarget, src.Match, src.Value)
                );

        internal static string format<T>(in Product<T> src)
            where T : IExpr
        {
            const char Delimiter = (char)LogicSym.And;
            var dst = text.buffer();
            var count = src.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var expr = ref src[i];
                dst.Append(expr.Format());
                if(i != count - 1)
                    dst.Append(Delimiter);

            }
            return dst.Emit();
        }

        internal static string format<C>(in SumOfProducts<C> src)
            where C : IExpr
        {
            const char Delimiter = (char)LogicSym.Or;
            var dst = text.buffer();
            var count = src.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var product = ref src[i];

                dst.Append(Chars.LParen);
                dst.Append(product.Format());
                dst.Append(Chars.RParen);

                if(i != count - 1)
                    dst.Append(Delimiter);
            }

            return dst.Emit();
        }
    }
}