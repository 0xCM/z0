//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    partial class XFs
    {
        public static BinaryWriter BinaryWriter(this FS.FilePath dst)
            => new BinaryWriter(File.Open(dst.EnsureParentExists().Name, FileMode.Create));
    }
}