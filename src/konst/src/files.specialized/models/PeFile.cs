//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a file that conforms to the portable executable format
    /// </summary>
    public readonly struct PeFile : IPeFile<PeFile>
    {
        public FS.FilePath Path {get;}

        public PeFileKind FileKind {get;}

        [MethodImpl(Inline)]
        public PeFile(FS.FilePath path)
        {
            Path = path;
            FileKind = Enums.parse(Path.Ext.Name, PeFileKind.None);
        }

        [MethodImpl(Inline)]
        public PeFile(FS.FilePath path, PeFileKind kind)
        {
            Path = path;
            FileKind = kind;
        }
    }
}