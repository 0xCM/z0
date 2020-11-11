//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct JsonText : ITextual, IContented<string>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public JsonText(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Content.GetHashCode();
        }

        [MethodImpl(Inline)]
        public static implicit operator JsonText(string src)
            => new JsonText(src);

        public static JsonText Empty
           => new JsonText(EmptyString);

        public int Length
        {
            [MethodImpl(Inline)]
            get => Content?.Length ?? 0;
        }
    }
}