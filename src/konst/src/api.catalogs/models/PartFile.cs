//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    /// <summary>
    /// Specifies a part-owned file path
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PartFile
    {
        public readonly PartId Part;

        public readonly PartFileKind Kind;

        public readonly FS.FilePath Path;

        [MethodImpl(Inline)]
        public PartFile(PartId part, PartFileKind kind, FS.FilePath path)
        {
            Part = part;
            Kind = kind;
            Path = path;
        }
    }
}