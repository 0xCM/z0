//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SyntaxNodeKey : IDataTypeEquatable<SyntaxNodeKey>
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public SyntaxNodeKey(ulong value)
            => Value = value;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Value != 0;
        }

        [MethodImpl(Inline)]
        public bool Equals(SyntaxNodeKey src)
            => Value == src.Value;

        public override bool Equals(object src)
            => src is SyntaxNodeKey x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();

        public string Format()
            => Value.FormatHex(zpad:false, specifier:true, prespec: false);

        public override string ToString()
            => Format();

        public static implicit operator SyntaxNodeKey(ulong src)
            => new SyntaxNodeKey(src);

        public static SyntaxNodeKey Empty
            => default;
    }
}