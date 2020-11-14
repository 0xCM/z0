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

    public readonly struct ScriptSymbol : IScriptSymbol
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public ScriptSymbol(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public ScriptSymbol(char name)
            => Name = name.ToString();

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ScriptSymbol(string name)
            => new ScriptSymbol(name);

        [MethodImpl(Inline)]
        public static implicit operator ScriptSymbol(char name)
            => new ScriptSymbol(name);

        [MethodImpl(Inline)]
        public static ScriptSymbol operator + (ScriptSymbol a, ScriptSymbol b)
            => combine(a,b);
    }
}