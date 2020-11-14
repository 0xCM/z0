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
    using static Scripts;

    public struct ScriptDirVar : IScriptVar<ScriptVar>
    {
        public ScriptSymbol Symbol {get;}

        public ScriptVarValue Value {get;}

        [MethodImpl(Inline)]
        public ScriptDirVar(ScriptSymbol name, ScriptVarValue value)
        {
            Symbol = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public ScriptDirVar(ScriptSymbol name)
        {
            Symbol = name;
            Value = ScriptVarValue.Empty;
        }

        [MethodImpl(Inline)]
        public static implicit operator ScriptDirVar((ScriptSymbol symbol, ScriptVarValue value) src)
            => new ScriptDirVar(src.symbol, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ScriptVar(ScriptDirVar src)
            => new ScriptDirVar(src.Symbol, src.Value);

        [MethodImpl(Inline)]
        public static ScriptDirVar operator + (ScriptDirVar a, ScriptDirVar b)
            => combine(a,b);
    }
}