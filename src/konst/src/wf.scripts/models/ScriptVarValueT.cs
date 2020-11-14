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

    public readonly struct ScriptVarValue<T> : IScriptVarValue<T>
    {
        public T Content {get;}

        [MethodImpl(Inline)]
        public ScriptVarValue(T name)
            => Content = name;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => empty(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => nonempty(this);
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ScriptVarValue<T>(T content)
            => new ScriptVarValue<T>(content);

        [MethodImpl(Inline)]
        public static implicit operator T(ScriptVarValue<T> src)
            => src.Content;

        public static ScriptVarValue<T> Empty
            => new ScriptVarValue<T>(default(T));
    }
}