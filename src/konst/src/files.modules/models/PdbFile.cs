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
    /// Represents a pdb file
    /// </summary>
    public readonly struct PdbFile : IPeFile<PdbFile>
    {
        public FS.FilePath Path {get;}

        public PeFileKind Kind
            => PeFileKind.Pdb;

        [MethodImpl(Inline)]
        public PdbFile(FS.FilePath path)
            => Path = path;

        [MethodImpl(Inline)]
        public static implicit operator PdbFile(FS.FilePath src)
            => new PdbFile(src);
    }
}