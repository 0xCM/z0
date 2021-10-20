//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using XF = ExprFormats;

    partial struct lang
    {
        internal static string format<T>(in Production<T> src)
            where T : IExpr
                => string.Format("<{0}> -> {1}", src.Name, src.Rhs.Format());

        internal static string format(in StringLiteral src)
            => string.Format(XF.Definition, src.Name, RP.enquote(src.Value));

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
    }
}