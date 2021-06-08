//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum TextEncodingKind : byte
    {
        None = 0,

        Asci = 7,

        Utf8 = 8,

        Utf16 = 16,

        Utf32 = 32
    }

    public interface ITextEncodingKind
    {
        TextEncodingKind Kind {get;}
    }

    public interface ITextEncodingKind<T> : ITextEncodingKind
        where T : unmanaged, ITextEncodingKind<T>
    {

    }

    public readonly struct TextEncodingKind<T> : ITextEncodingKind<T>
        where T : unmanaged, ITextEncodingKind<T>
    {
        public TextEncodingKind Kind
        {
            [MethodImpl(Inline)]
            get => default(T).Kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator TextEncodingKind<T>(T src)
            => default;
    }
}