//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct JsonText : ITextual
    {
        public static JsonText Empty => new JsonText(EmptyString);

        public readonly string Content;

        [MethodImpl(Inline)]
        public JsonText(string content)
        {
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Content.GetHashCode();
        }
    }
}