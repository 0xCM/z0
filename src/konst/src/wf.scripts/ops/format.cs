//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        [Op, Closures(Closure)]
        public static string format<T>(ScriptSymbol<T> src)
            => string.Format("{0}", src.Name);

        [Op, Closures(Closure)]
        public static string format<T>(ScriptVarValue<T> src)
            => string.Format("{0}", src.Content);
        [Op]
        public static string format(ScriptVar src)
            => string.Format("{0}={1}",src.Symbol, src.Value);

        [Op]
        public static string format(ScriptVarValue src)
            => src.Content ?? EmptyString;

        [Op]
        public static string format(IScriptVar src)
            => string.Format("{0}={1}", src.Symbol, src.Value);

        [Op]
        public static string format(ScriptSymbol src)
            => string.Format("$({0})",src.Name ?? EmptyString);

        [Op]
        public static string format(IScriptVars src)
        {
            var dst = new StringBuilder();
            foreach(var member in src.Members())
                dst.AppendLine(format(member));
            return dst.ToString();
        }

        [Op]
        public static string format(ScriptDirVars src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }
    }
}