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

    public readonly struct CmdVarValue : ICmdVarValue<string>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdVarValue(string name)
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
            => CmdVars.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdVarValue(string content)
            => new CmdVarValue(content);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdVarValue src)
            => src.Content;

        public static CmdVarValue Empty
            => new CmdVarValue(EmptyString);
    }
}