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
        [Op]
        public static string format(in LocatedImage src)
        {
            var expression = text.bracket(text.concat(src.BaseAddress, Chars.Comma, Chars.Space, src.EndAddress, Chars.Colon, src.Size));
            return text.assign(src.Name, expression);
        }

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(IPart src)
        {
            var match =  Path.GetFileNameWithoutExtension(src.Owner.Location);
            var modules = ImageMaps.modules(Process.GetCurrentProcess());
            var module = modules.Where(m => Path.GetFileNameWithoutExtension(m.Path.Name) == match).First();
            return module.Base;
        }

        [MethodImpl(Inline), Op]
        public static LocatedImageIndex current()
            => index(Process.GetCurrentProcess());

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

        /// <summary>
        /// Captures the current process state
        /// </summary>
        /// <param name="src">The source process</param>
        [MethodImpl(Inline), Op]
        public static ProcessState state(Process src)
        {
            var dst = new ProcessState();
            map(src, ref dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        static ImageMap load(ProcessState process, LocatedImage[] images, MemoryAddress[] locations, ProcessModuleRow[] modules)
            => new ImageMap(process, images, memory.sort(locations), modules);
    }
}