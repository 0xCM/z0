//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;

    public readonly struct Clr
    {
        public static Assembly load(FS.FilePath image, FS.FilePath pdb)
            => Assembly.Load(image.ReadBytes(), pdb.ReadBytes());
    }
}