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

    public readonly struct CmdVarSymbol : ICmdVarSymbol
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public CmdVarSymbol(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public CmdVarSymbol(char name)
            => Name = name.ToString();

        [MethodImpl(Inline)]
        public string Format()
            => CmdFormat.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdVarSymbol(string name)
            => new CmdVarSymbol(name);

        [MethodImpl(Inline)]
        public static implicit operator CmdVarSymbol(char name)
            => new CmdVarSymbol(name);

        [MethodImpl(Inline)]
        public static CmdVarSymbol operator + (CmdVarSymbol a, CmdVarSymbol b)
            => CmdVars.combine(a,b);
    }
}