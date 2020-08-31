//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        /// <summary>
        /// Defines a host-specialized filename
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="hostname">The host api name</param>
        /// <param name="ext">The file extension</param>
        [MethodImpl(Inline), Op]
        public static FileName file(PartId part, string hostname, FileExt ext)
            => file(text.concat(part.Format(), Chars.Dot, hostname), ext);

        [MethodImpl(Inline), Op]
        public static FileName file(PathPart name)
            => new FileName(name);

        [MethodImpl(Inline), Op]
        public static FileName file(PathPart name, FileExt ext)
            => new FileName(name, ext);

        [MethodImpl(Inline), Op]
        public static FileName file(PathPart name, string ext)
            => new FileName(name, FS.ext(ext));

        [MethodImpl(Inline)]
        public static FileName file(PartId owner, string hostname, FileExtension ext)
            => file(text.concat(owner.Format(), Chars.Dot, hostname), ext);

        [MethodImpl(Inline)]
        public static FileName file(string name)
            => new FileName(name);

        [MethodImpl(Inline)]
        public static FileName file(string name, string x)
            => new FileName(name, ext(x));

        [MethodImpl(Inline)]
        public static FileName file(string name, FileExtension x)
            => new FileName(name, ext(x.Name));
    }
}