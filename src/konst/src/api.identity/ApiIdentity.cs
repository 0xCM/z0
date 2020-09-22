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
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        [MethodImpl(Inline), Op]
        public static Option<byte> imm8(OpIdentity src)
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(IDI.Imm), out var immval))
                return immval;
            else
                return Option.none<byte>();
        }

        /// <summary>
        /// Returns the duplicate identities found in the source stream, if any; otherwise, returns an empty array
        /// </summary>
        /// <param name="src">The identities to search for duplicates</param>
        [Op]
        public static OpIdentity[] duplicates(OpIdentity[] src)
        {
            var index = new Dictionary<OpIdentity,int>();
            var distinct = src.ToHashSet();
            if(distinct.Count != src.Count())
            {
                foreach(var id in src)
                {
                    if(index.TryGetValue(id, out var count ))
                        index[id] = ++count;
                    else
                        index[id] = 1;
                }
            }

            return (from kvp in index where kvp.Value > 1 select kvp.Key).ToArray();
        }

        readonly struct ArtifactIdentities : IMultiDiviner
        {
            [MethodImpl(Inline)]
            public TypeIdentity DivineIdentity(Type src)
                => identify(src);

            [MethodImpl(Inline)]
            public OpIdentity DivineIdentity(MethodInfo src)
                => identify(src);

            [MethodImpl(Inline)]
            public OpIdentity DivineIdentity(Delegate src)
                => identify(src);

            [MethodImpl(Inline)]
            public GenericOpIdentity GenericIdentity(MethodInfo src)
                => generic(src);
        }
    }
}