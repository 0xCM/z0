//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Text : IDataType<Text>
    {
        public TextKind Kind {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public Text(TextKind kind, string content)
        {
            Kind = kind;
            Content = content;
        }

        public string Format()
            => Content;

        public override string ToString()
            => Format();
    }
}