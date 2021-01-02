//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static Konst;

    [ApiHost]
    public partial class ApiIdentityKinds
    {
        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static HashSet<Type> typeset(NumericKind k)
            => GetNumericTypeSet(k);

        /// <summary>
        /// Specifies the primal types identified by a <see cref='NumericKind' />
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static HashSet<NumericKind> kindset(NumericKind k)
            => GetNumericKindSet(k);

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        [MethodImpl(Inline)]
        public static string owner(Type host)
            => ApiIdentify.part(host).Format();

        static ConcurrentDictionary<NumericKind, HashSet<NumericKind>> NumericKindSets {get;}
            = new ConcurrentDictionary<NumericKind, HashSet<NumericKind>>();

        static ConcurrentDictionary<NumericKind, HashSet<Type>> NumericTypeSets {get;}
            = new ConcurrentDictionary<NumericKind, HashSet<Type>>();

        [MethodImpl(Inline)]
        static HashSet<NumericKind> GetNumericKindSet(NumericKind kind)
            => NumericKindSets.GetOrAdd(kind, ApiIdentify.distinct);

        [MethodImpl(Inline)]
        static HashSet<Type> GetNumericTypeSet(NumericKind kind)
            => NumericTypeSets.GetOrAdd(kind, ApiIdentify.typeset);
    }
}