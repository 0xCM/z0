//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    [ApiHost("api.identity")]
    public readonly partial struct ApiIdentity
    {
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


        /// <summary>
        /// Disables the generic indicator
        /// </summary>
        static OpIdentity WithoutGeneric(OpIdentity src)
        {
            var parts = ApiIdentity.components(src).ToArray();
            if(parts.Length < 2)
                return src;

            if(parts[1].Identifier[0] != IDI.Generic)
                return src;

            parts[1] = parts[1].WithText(parts[1].Identifier.Substring(1));
            return ApiIdentity.build(parts);
        }
    }
}