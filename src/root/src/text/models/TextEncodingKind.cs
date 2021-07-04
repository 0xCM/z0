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

        Asci = 1,

        Utf8 = 2,

        Utf16 = 3,

        Utf32 = 4,

        Unicode = 5,
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