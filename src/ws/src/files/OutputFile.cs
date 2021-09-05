//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct OutputFile : IFsEntry<OutputFile>
    {
        public FS.FilePath Path {get;}

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Path.Name;
        }

        [MethodImpl(Inline)]
        public OutputFile(FS.FilePath src)
            => Path = src;

        [MethodImpl(Inline)]
        public static implicit operator OutputFile(FS.FilePath src)
            => new OutputFile(src);

        [MethodImpl(Inline)]
        public static implicit operator FS.FilePath(OutputFile src)
            => src.Path;
    }
}