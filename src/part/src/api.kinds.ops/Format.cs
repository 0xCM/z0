//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XKinds
    {
        [MethodImpl(Inline), Op]
        public static string Format(this SegBlockKind k)
            => k != 0 ? k.ToString() : string.Empty;

        [MethodImpl(Inline), Op]
        public static string Format(this PartId id)
            => Part.format(id);

        [MethodImpl(Inline), Op]
        public static bool IsDefined(this ApiClass src)
            => src != 0;


        [MethodImpl(Inline), Op]
        public static bool IsUserApi(this ApiClass src)
            => src.IsDefined() && !src.IsOpaque();

        [MethodImpl(Inline), Op]
        public static string Format(this ApiClass src)
            => src.IsOpaque() ? "opaque" : src.ToString().ToLower();

        [MethodImpl(Inline), Op]
        public static string Format(this ExternId id)
            => Part.format(id);

        [MethodImpl(Inline), Op]
        public static PartId Id(this Assembly src)
            => Part.id(src);
    }
}