//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IntelIntrinsicsModel
    {
        public struct Category : ITextual
        {
            public const string ElementName = "category";

            public string Content;

            [MethodImpl(Inline)]
            public Category(string src)
            {
                Content = src;
            }

            public string Format()
                => Content;

            public override string ToString()
                => Content;

            [MethodImpl(Inline)]
            public static implicit operator Category(string src)
                => new Category(src);
        }
    }
}