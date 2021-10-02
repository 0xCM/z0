//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct RuleModels
    {
        [StructLayout(LayoutKind.Sequential)]
        public readonly struct Text : IDataType<Text>
        {
            public TextKind Kind {get;}

            public string Content {get;}

            [MethodImpl(Inline)]
            public Text(TextKind kind, string content)
            {
                Kind = kind;
                Content = content;
            }

            public string Format()
                => Content;

            public override string ToString()
                => Format();
        }
    }
}