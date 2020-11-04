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

    [ApiHost(ApiNames.ApiIdentify, true)]
    public readonly partial struct ApiIdentify
    {
        [MethodImpl(Inline), Op]
        public static string identifier(ApiClass src)
            => string.Format("k{0}", src != 0 ? src.Format() : "0");

        [MethodImpl(Inline), Op]
        public static string identifier(PartId src)
            => src.Format();

        [MethodImpl(Inline)]
        public static int compare<T>(in T a, in T b)
            where T : IIdentified
                => text.denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, object b)
            where T : IIdentified
                => text.equals(a.Identifier, b is T x ? x.Identifier : EmptyString, NoCase);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, in T b)
            where T : IIdentified
                => text.equals(a.Identifier, b.Identifier, NoCase);

        [MethodImpl(Inline)]
        public static int hash<T>(in T src)
            where T : IIdentified
                => text.denullify(src.Identifier).GetHashCode();

        [MethodImpl(Inline), Op]
        public static IMultiDiviner diviner()
            => new ArtifactIdentities();
    }
}