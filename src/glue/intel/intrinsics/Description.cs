//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class IntrinsicsModels
    {
        public struct Description : ITextual
        {
            public const string ElementName = "description";

            public string Content;

            [MethodImpl(Inline)]
            public Description(string src)
            {
                Content = src.Replace("\r\n", " ");
            }

            public string Format()
                => Content;

            public override string ToString()
                => Content;

            [MethodImpl(Inline)]
            public static implicit operator Description(string src)
                => new Description(src);
        }
    }
}