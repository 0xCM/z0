//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolHelp : IToolHelp
    {
        public ToolId Id {get;}

        public utf8 Content {get;}

        [MethodImpl(Inline)]
        public ToolHelp(ToolId id, string content)
        {
            Id = id;
            Content = content;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id.IsEmpty || text.empty(Content);
        }

        public static ToolHelp Empty
        {
            [MethodImpl(Inline)]
            get => new ToolHelp(ToolId.Empty, EmptyString);
        }
    }
}