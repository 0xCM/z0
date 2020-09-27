//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolCommand : ITextual
    {
        public readonly FS.FilePath ToolPath;

        public ToolArgs Args;

        [MethodImpl(Inline)]
        public ToolCommand(FS.FilePath path, ToolArgs args)
        {
            ToolPath = path;
            Args = args;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Join(Chars.Space, ToolPath.Format(PathSeparator.BS), Args);

        public override string ToString()
            => Format();
    }
}