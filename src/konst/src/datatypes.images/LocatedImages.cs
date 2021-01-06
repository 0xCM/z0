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
    public readonly partial struct LocatedImages
    {
        [Op]
        public static string format(in LocatedImage src)
        {
            var expression = text.bracket(text.concat(src.BaseAddress, Chars.Comma, Chars.Space, src.EndAddress, Chars.Colon, src.Size));
            return text.assign(src.Name, expression);
        }

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from the main module of the executing <see cref='Process'/>
        /// </summary>
        /// <param name="src">The source module</param>
        public static LocatedImage main()
            => locate(Process.GetCurrentProcess().MainModule);

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from the main module of a specified <see cref='Process'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static LocatedImage locate(Process src)
            => locate(src.MainModule);

        [MethodImpl(Inline), Op]
        public static Index<LocatedImage> index()
            => index(Process.GetCurrentProcess());

        [Op]
        public static Index<LocatedImage> index(Process src)
            => src.Modules.Cast<ProcessModule>().Map(locate).OrderBy(x => x.BaseAddress);

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
