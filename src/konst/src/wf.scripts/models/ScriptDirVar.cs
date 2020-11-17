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

    public struct ScriptDirVar : IScriptVar<FS.FolderPath>
    {
        public ScriptSymbol Symbol {get;}

        public FS.FolderPath Value {get;}

        [MethodImpl(Inline)]
        public ScriptDirVar(ScriptSymbol name, FS.FolderPath value)
        {
            Symbol = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public ScriptDirVar(ScriptSymbol name)
        {
            Symbol = name;
            Value = FS.FolderPath.Empty;
        }

        [MethodImpl(Inline)]
        public static implicit operator ScriptDirVar((ScriptSymbol symbol, FS.FolderPath value) src)
            => new ScriptDirVar(src.symbol, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ScriptVar(ScriptDirVar src)
            => new ScriptDirVar(src.Symbol, src.Value);
    }
}