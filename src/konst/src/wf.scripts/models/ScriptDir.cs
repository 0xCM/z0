//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static CmdScripts;

    public struct ScriptDir : IScriptVar<ScriptVar>
    {
        public ScriptSymbol Symbol {get;}

        public ScriptVarValue Value {get;}

        [MethodImpl(Inline)]
        public ScriptDir(ScriptSymbol name, ScriptVarValue value)
        {
            Symbol = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ScriptDir((ScriptSymbol symbol, ScriptVarValue value) src)
            => new ScriptDir(src.symbol, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ScriptVar(ScriptDir src)
            => new ScriptDir(src.Symbol, src.Value);

        [MethodImpl(Inline)]
        public static ScriptDir operator + (ScriptDir a, ScriptDir b)
            => combine(a,b);
    }
}