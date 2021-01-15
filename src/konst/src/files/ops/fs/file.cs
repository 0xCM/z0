//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static FileName file(PartId part, FileExt ext)
            => file(Strings.concat(part.Format()), ext);

        [MethodImpl(Inline), Op]
        public static FileName file(ApiHostUri host, FileExt ext)
            => FS.file(Z0.text.concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        /// <summary>
        /// Defines a host-specialized filename
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="hostname">The host api name</param>
        /// <param name="ext">The file extension</param>
        [MethodImpl(Inline), Op]
        public static FileName file(PartId part, string hostname, FileExt ext)
            => file(Z0.text.concat(part.Format(), Chars.Dot, hostname), ext);

        [MethodImpl(Inline), Op]
        public static FileName file(PathPart name, FileExt ext)
            => new FileName(name, ext);

        [MethodImpl(Inline), Op]
        public static FileName file(string name)
            => new FileName(name);

        [MethodImpl(Inline), Op]
        public static FileName file(Name name, string x)
            => new FileName(name.Format(), ext(x));
    }
}