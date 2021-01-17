//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;
    using System.IO;
    using System.Reflection;

    using static Part;

    partial struct ImageMaps
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(IPart src)
            => @base(src.Owner);

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(Assembly src)
            => @base(Path.GetFileNameWithoutExtension(src.Location));

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(Name procname)
        {
            var match =  procname.Content;
            var mods = modules(Process.GetCurrentProcess());
            var module = mods.Where(m => Path.GetFileNameWithoutExtension(m.ImagePath.Name) == match).First();
            return module.BaseAddress;
        }
    }
}