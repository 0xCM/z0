//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Collections;

    using static Seed;

    public readonly struct HashTable
    {
        [MethodImpl(Inline)]
        public static HashTable<K,V> Create<K,V>(IReadOnlyDictionary<K,V> src)
            => new HashTable<K,V>(src);

        [MethodImpl(Inline)]
        public static HashTable<K,V> Create<K,V>(Dictionary<K,V> src)
            => new HashTable<K,V>(src);

        /// <summary>
        /// Creates a boxed hash table from an enumerable sequence of key-value pairs
        /// </summary>
        /// <param name="src">The kvp sequence, hopefully</param>
        [MethodImpl(Inline)]
        internal static HashTable Create(IEnumerable src)        
            => new HashTable(src);
        
        HashTable(IEnumerable src)
        {
            var enumerator = src.GetEnumerator();
            var isFirst = true;
            var tPair = default(Pair<Type>);
            var pPair = default(Pair<PropertyInfo>);
            var kvpType = typeof(void);
            var dst = new Dictionary<object,object>();
            while(enumerator.MoveNext())
            {
                if(isFirst)
                {
                    isFirst = false;
                    kvpType = enumerator.Current.GetType();

                    var kvpProps = kvpType.Properties().Instance().ToArray();
                    if(kvpProps.Length != 2)
                        break;

                    var args = kvpType.SuppliedTypeArgs();
                    if(args.Length != 2)
                        break;

                    pPair = Pairs.pair(kvpProps[0],kvpProps[1]);
                    tPair = Pairs.pair(args[0],args[1]);
                }

                var kvp = enumerator.Current;
                var key = pPair.Left.GetValue(kvp);
                var value = pPair.Right.GetValue(kvp);
                if(key == null || value == null)
                    break;

                dst[key] = value;                                
            }

            Data = dst;
        }

        IReadOnlyDictionary<object,object> Data {get;}
    }
}