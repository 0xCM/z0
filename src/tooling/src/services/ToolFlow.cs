//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static Blit;

    public readonly struct ToolFlow
    {
        public text15 Tool {get;}

        public FS.FilePath Source {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public ToolFlow(text15 tool, FS.FilePath src, FS.FilePath dst)
        {
            Tool = tool;
            Source = src;
            Target = dst;
        }

        public string Format()
            => string.Format("{0}:{1} -> {2}", Tool, Source, Target);

        public override string ToString()
            => Format();
    }
}