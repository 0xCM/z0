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

    /// <summary>
    /// Represents a path to a file that defines a solution
    /// </summary>
    public readonly struct SlnFile : ITextual
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public SlnFile(FS.FilePath src)
            => Path = src;

        [MethodImpl(Inline)]
        public string Format()
            => Path.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator SlnFile(FS.FilePath src)
            => new SlnFile(src);
    }
}