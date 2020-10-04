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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static string Format(this PartId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static bool IsDefined(this ApiOpId src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool Opaque(this ApiOpId src)
            => src >= ApiOpId.Opaque;

        [MethodImpl(Inline)]
        public static bool IsUserApi(this ApiOpId src)
            => src.IsDefined() && !src.Opaque();

        [MethodImpl(Inline)]
        public static string Format(this ApiOpId src)
            => src.Opaque() ? "opaque" : src.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format(this ExternId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            => Part.id(src);
    }
}