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

    using static Part;

    [ApiHost]
    public readonly partial struct ImageMaps
    {

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(IPart src)
        {
            var match =  Path.GetFileNameWithoutExtension(src.Owner.Location);
            var modules = ImageMaps.modules(Process.GetCurrentProcess());
            var module = modules.Where(m => Path.GetFileNameWithoutExtension(m.ImagePath.Name) == match).First();
            return module.BaseAddress;
        }

        /// <summary>
        /// Captures the current process state
        /// </summary>
        /// <param name="src">The source process</param>
        [MethodImpl(Inline), Op]
        public static ProcessState state(Process src)
        {
            var dst = new ProcessState();
            fill(src, ref dst);
            return dst;
        }
    }
}