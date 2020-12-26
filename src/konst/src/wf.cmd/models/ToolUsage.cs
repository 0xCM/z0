//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines the usage syntax of a command or tool
    /// </summary>
    [Datatype]
    public readonly struct ToolUsage : ITextual, IContented<string>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public ToolUsage(string content)
            => Content = content;

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolUsage(string src)
            => new ToolUsage(src);

        [MethodImpl(Inline)]
        public static implicit operator string(ToolUsage src)
            => src.Content;
    }
}