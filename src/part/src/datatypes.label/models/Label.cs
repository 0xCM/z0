//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Label : ILabel
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public Label(string label)
            => Content = label;
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator string(Label src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Label(string src)
            => new Label(src);

        public static Label Empty
            => new Label(EmptyString);
    }
}