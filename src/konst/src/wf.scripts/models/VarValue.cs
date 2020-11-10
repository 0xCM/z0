//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Scripts
    {
        public struct VarValue
        {
            public string Content;

            [MethodImpl(Inline)]
            public VarValue(string name)
                => Content = name;

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => text.blank(Content);
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => text.nonempty(Content);
            }

            [MethodImpl(Inline)]
            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator VarValue(string content)
                => new VarValue(content);

            [MethodImpl(Inline)]
            public static implicit operator string(VarValue src)
                => src.Content;

            public static VarValue Empty
                => new VarValue(EmptyString);
        }
    }
}