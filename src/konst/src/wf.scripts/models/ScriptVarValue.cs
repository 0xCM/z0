//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Scripts;

    public readonly struct ScriptVarValue : IScriptVarValue<string>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public ScriptVarValue(string name)
            => Content = name;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Content);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content);
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ScriptVarValue(string content)
            => new ScriptVarValue(content);

        [MethodImpl(Inline)]
        public static implicit operator string(ScriptVarValue src)
            => src.Content;

        public static ScriptVarValue Empty
            => new ScriptVarValue(EmptyString);
    }
}