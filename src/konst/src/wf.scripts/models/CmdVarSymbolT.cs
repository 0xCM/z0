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
    using static WfScripts;

    public readonly struct CmdVarSymbol<T> : ICmdVarSymbol<T>
    {
        public T Id {get;}

        public string Name
        {
            get => Id?.ToString() ?? EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdVarSymbol(T id)
            => Id= id;

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdVarSymbol<T>(T id)
            => new CmdVarSymbol<T>(id);

        [MethodImpl(Inline)]
        public static CmdVarSymbol operator + (CmdVarSymbol<T> a, CmdVarSymbol<T> b)
            => CmdVars.combine(a,b);
    }
}