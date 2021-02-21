//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TextProp : ITextual
    {
        public Name Name {get;}

        public TextBlock Value {get;}

        [MethodImpl(Inline)]
        public TextProp(Name name, TextBlock value)
        {
            Name = name;
            Value = value;
        }

        PropFormat<TextBlock> FormatProp
            => new PropFormat<TextBlock>(Name, Value);
        public string Format()
            => FormatProp.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TextProp((string name, string value) src)
            => new TextProp(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator PropFormat<TextBlock>(TextProp src)
            => src.FormatProp;
    }
}