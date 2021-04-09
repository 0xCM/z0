//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ControlScriptNames
    {
        public static FS.FileName BuildRespack => FS.file("build-respack", FS.Cmd);

        public static FS.FileName PackRespack => FS.file("pack-respack", FS.Cmd);
    }
}