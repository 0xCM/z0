//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ByteSpanProperty : ITextual
    {
        public readonly string Name;

        public readonly byte[] Data;

        public readonly bool IsStatic;

        public readonly VisibilityKind Access;

        const string PropDataType = "ReadOnlySpan<byte>";

        const string PropLambda = " => ";

        [MethodImpl(Inline)]
        public ByteSpanProperty(string name, byte[] data, bool isStatic = true, VisibilityKind access = VisibilityKind.Public)
        {
            Name = name;
            Data = data;
            IsStatic = isStatic;
            Access = access;
        }

        public string Format()
        {
            var dst = text.build();
            dst.Append(Access.ToString().ToLower());
            dst.Append(Chars.Space);
            dst.Append(IsStatic ? text.rspace("static") : string.Empty);
            dst.Append(PropDataType);
            dst.Append(Chars.Space);
            dst.Append(Name);
            dst.Append(PropLambda);
            dst.Append(string.Concat("new byte", text.bracket(Data.Length), text.embrace(Render.data<byte>(Data))));
            dst.Append(Chars.Semicolon);
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}