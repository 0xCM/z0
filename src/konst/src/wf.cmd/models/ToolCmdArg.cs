//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ToolCmdArg
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public ToolCmdArg(string value)
        {
            Content = value ?? EmptyString;
        }

        public string Format()
            => Content ?? EmptyString;


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolCmdArg(string src)
            => new ToolCmdArg(src);
    }
}