//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = FileRoles;

    /// <summary>
    /// Represents a native executable
    /// </summary>
    public readonly struct IncludePath : IFsEntry<IncludePath>
    {
        public FS.FolderPath Path {get;}

        [MethodImpl(Inline)]
        public IncludePath(FS.FolderPath src)
            => Path = src;

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Path.Name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator IncludePath(FS.FolderPath src)
            => new IncludePath(src);

        public static IncludePath Empty
        {
            [MethodImpl(Inline)]
            get => new IncludePath(FS.FolderPath.Empty);
        }
    }
}