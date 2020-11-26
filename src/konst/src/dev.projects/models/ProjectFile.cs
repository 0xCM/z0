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
    /// Represents a path to a file that defines a project
    /// </summary>
    public readonly struct ProjectFile : IFsEntry<ProjectFile>
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public ProjectFile(FS.FilePath src)
            => Path = src;

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Path.Name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Path.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ProjectFile(FS.FilePath src)
            => new ProjectFile(src);
    }
}