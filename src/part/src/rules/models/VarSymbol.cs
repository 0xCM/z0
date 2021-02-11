//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Rules;

    public readonly struct VarSymbol : IVarSymbol
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public VarSymbol(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public VarSymbol(char name)
            => Name = name.ToString();

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        [MethodImpl(Inline)]
        public string Format(VarContextKind vck)
            => api.format(vck, this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator VarSymbol(string name)
            => new VarSymbol(name);

        [MethodImpl(Inline)]
        public static implicit operator VarSymbol(char name)
            => new VarSymbol(name);
    }
}