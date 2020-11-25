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
    using static CmdVarTypes;

    partial struct WfScripts
    {
        [Op, Closures(Closure)]
        public static string format<T>(CmdVarSymbol<T> src)
            => string.Format("{0}", src.Name);

        [Op]
        public static string format(CmdScriptVar src)
            => string.Format("{0}={1}",src.Symbol, src.Value);

        [Op]
        public static string format(CmdVarValue src)
            => src.Content ?? EmptyString;

        [Op]
        public static string format(ICmdVar src)
            => string.Format("{0}={1}", src.Symbol, src.Value);

        [Op]
        public static string format(CmdVarSymbol src)
            => string.Format("$({0})",src.Name ?? EmptyString);

        [Op]
        public static string format(ICmdVars src)
        {
            var dst = new StringBuilder();
            foreach(var member in src.Members())
                dst.AppendLine(format(member));
            return dst.ToString();
        }

        [Op]
        public static string format(DirVars src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }
    }
}