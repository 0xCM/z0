//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static z;
    using static Konst;

    partial struct CmdScripts
    {
        [MethodImpl(Inline), Op]
        public static ScriptSymbol combine(ScriptSymbol a, ScriptSymbol b)
            => new ScriptSymbol(string.Format("{0}{1}", a, b));

        [Op]
        public static ScriptDirVar combine(ScriptDirVar a, ScriptDirVar b)
        {
            var symbol = a.Symbol + PathSep + b.Symbol;
            var value = Path.Combine(a.Value, b.Value);
            return (symbol,value);
        }
    }
}