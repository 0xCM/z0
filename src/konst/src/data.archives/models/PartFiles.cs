//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly struct PartFiles
    {
        public readonly FS.FolderPath Root;

        public readonly FS.Files Parsed;

        public readonly FS.Files Hex;

        public readonly FS.Files Asm;

        [MethodImpl(Inline)]
        public PartFiles(FS.FolderPath root, FS.Files parsed, FS.Files hex, FS.Files asm)
        {
            Root = root;
            Asm = asm;
            Hex = hex;
            Parsed = parsed;
        }
    }
}