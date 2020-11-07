//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Text;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        [MethodImpl(Inline), Op]
        public static string format(Var src)
            => string.Format("{0}={1}",src.Symbol, src.Value);

        [MethodImpl(Inline), Op]
        public static string format(VarValue src)
            => src.Content ?? EmptyString;

        [MethodImpl(Inline), Op]
        public static string format(IScriptVar src)
            => string.Format("{0}={1}", src.Symbol, src.Value);

        [MethodImpl(Inline), Op]
        public static string format(Symbol src)
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
        public static string format(ScriptVars src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }
    }
}