//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents a path to a file that is within the scope of a project
    /// </summary>
    public readonly partial struct ProjectFile : IFsEntry<ProjectFile>
    {
        public FileKind Kind {get;}

        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public ProjectFile(FileKind kind, FS.FilePath path)
        {
            Kind = kind;
            Path = path;
        }

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
    }
}