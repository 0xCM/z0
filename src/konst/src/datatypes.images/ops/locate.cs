//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Part;

    partial struct ImageMaps
    {
        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from the main module of a specified <see cref='Process'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static LocatedImage locate(Process src)
            => locate(src.MainModule);

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from a specified <see cref='ProcessModule'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [Op]
        public static LocatedImage locate(ProcessModule src)
        {
            var path = FS.path(src.FileName);
            var part = ApiPartIdParser.part(path);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(path, part, entry, @base, size);
        }
    }
}