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

    public readonly struct ScriptSymbol<T> : IScriptSymbol<T>
    {
        public T Id {get;}

        public string Name
        {
            get => Id?.ToString() ?? EmptyString;
        }

        [MethodImpl(Inline)]
        public ScriptSymbol(T id)
            => Id= id;

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ScriptSymbol<T>(T id)
            => new ScriptSymbol<T>(id);

        [MethodImpl(Inline)]
        public static ScriptSymbol operator + (ScriptSymbol<T> a, ScriptSymbol<T> b)
            => combine(a,b);
    }
}