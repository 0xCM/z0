//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct EnvDirVar : IEnvVar<FS.FolderPath>
    {
        public VarSymbol Symbol {get;}

        public FS.FolderPath Value {get;}

        [MethodImpl(Inline)]
        public EnvDirVar(VarSymbol name, FS.FolderPath value)
        {
            Symbol = name;
            Value = value;
        }

        public string Format()
            => Rules.format(this);

        public string Format(VarContextKind vck)
            => Rules.format(vck, this);

        [MethodImpl(Inline)]
        public static implicit operator EnvDirVar((VarSymbol symbol, FS.FolderPath value) src)
            => new EnvDirVar(src.symbol, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ScriptVar(EnvDirVar src)
            => new EnvDirVar(src.Symbol, src.Value);
    }
}