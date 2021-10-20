//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public readonly struct StringLiteral
    {
        public Label Name {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public StringLiteral(Label name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => lang.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator StringLiteral((Label name, string value) src)
            => new StringLiteral(src.name, src.value);
    }
}