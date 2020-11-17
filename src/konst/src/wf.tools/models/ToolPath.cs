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

    public readonly struct ToolPath
    {
        public FS.FilePath Location {get;}

        [MethodImpl(Inline)]
        public ToolPath(FS.FilePath src)
            => Location = src;

        [MethodImpl(Inline)]
        public static implicit operator ToolPath(FS.FilePath src)
            => new ToolPath(src);

        [MethodImpl(Inline)]
        public static implicit operator FS.FilePath(ToolPath src)
            => src.Location;
    }
}