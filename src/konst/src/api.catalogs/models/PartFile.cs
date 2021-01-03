//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// Specifies a part-owned file path
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PartFile
    {
        public PartId Part {get;}

        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public PartFile(PartId part, FS.FilePath path)
        {
            Part = part;
            Path = path;
        }
    }
}