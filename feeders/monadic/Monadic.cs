//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Monadic)]

namespace Z0.Parts
{        
    public sealed class Monadic : Part<Monadic>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static ReflectionFlags;

    public static class Monadic
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// Selects the literal fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        internal static IEnumerable<FieldInfo> Literal(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsLiteral);

        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        internal static IEnumerable<FieldInfo> DeclaredFields(this Type src)
            => src.GetFields(BF_Declared);

        /// <summary>
        /// Constructs a mutable dictionary from a sequence of key-value pairs
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        internal static Dictionary<K,V> ToDictionary<K,V>(this IEnumerable<(K key, V value)> src)
            => new Dictionary<K,V>(src.Select(x => new KeyValuePair<K,V>(x.key,x.value)));
    }

    public interface IMonadic
    {
        
    }
}
