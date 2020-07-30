//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a symver-aligned build/publication version specifier
    /// </summary>
    public readonly struct BuildVersion
    {
        public readonly int Major;

        public readonly int Minor;

        public readonly int Patch;
        
        public readonly StringRef Pre;

        public readonly StringRef Build;

        [MethodImpl(Inline)]
        public BuildVersion(int major, int minor, int patch, string pre = "", string build = "")
        {
            Major = major;
            Minor = minor;
            Patch = patch;
            Pre = pre;
            Build = build;
        }
    }
}