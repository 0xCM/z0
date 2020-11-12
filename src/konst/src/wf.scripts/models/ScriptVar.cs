//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CmdScripts;

    public struct ScriptVar : IScriptVar<ScriptVar>
    {
        public ScriptSymbol Symbol {get;}

        public ScriptVarValue Value {get;}

        [MethodImpl(Inline)]
        public ScriptVar(ScriptSymbol name, ScriptVarValue value)
        {
            Symbol = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ScriptVar((ScriptSymbol symbol, ScriptVarValue value) src)
            => new ScriptVar(src.symbol, src.value);
    }
}