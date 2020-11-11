//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ToolHelp
    {
        public ToolId Tool {get;}
        
        public utf8 Content {get;}

        [MethodImpl(Inline)]
        public ToolHelp(ToolId tool, utf8 content)
        {
            Tool = tool;
            Content = content;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Tool.IsEmpty || Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Tool.IsNonEmpty && Content.IsNonEmpty;
        }

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static ToolHelp Empty
        {
            [MethodImpl(Inline)]
            get => new ToolHelp(ToolId.Empty, utf8.Empty);
        }
    }   
}