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

    using XF = ExprPatterns;

    partial struct lang
    {
        internal static string format<T>(in Production<T> src)
            where T : IExpr
                => string.Format("<{0}> -> {1}", src.Name, src.Term.Format());

        internal static string format(in Token src)
        {
            Span<char> buffer = stackalloc char[src.Length];
            for(var i=0; i<src.Length; i++)
                seek(buffer,i) = src[i];
            return text.format(buffer);
        }

        internal static string format<K>(in Token<K> src)
            where K : unmanaged
        {
            var dst = text.buffer();
            for(var i=0; i<src.Length; i++)
                dst.Append(src[i].Format());
            return dst.Emit();
        }

        internal static string format<K>(in Alphabet<K> src)
            where K : unmanaged
        {
            var dst = text.buffer();
            var count = src.MemberCount;
            dst.AppendFormat("{0}:{{", src.Name);
            for(var i=0; i<count; i++)
                dst.Append(src[i].Format());
            dst.Append("}");
            return dst.Emit();
        }
    }
}