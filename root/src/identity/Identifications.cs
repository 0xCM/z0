//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class Identifications
    {
        public static Identifications<V> Define<V>(params V[] src)
            where V : IIdentity<V>, new()
                => Identifications<V>.Define(src);

        public static Identifications<V> Init<V>()
            where V : IIdentity<V>, new()
                => Identifications<V>.Define();
    }

    public readonly struct Identifications<V> : IEnumerable<V>
        where V : IIdentity<V>, new()
    {   
        [MethodImpl(Inline)]
        static List<V> denullify(List<V> src)
            => isnull(src) ? Empty.values : src;

        public static Identifications<V> Empty => Define();

        readonly List<V> values;

        [MethodImpl(Inline)]
        internal static Identifications<V> Define(params V[] src)
            => new Identifications<V>(src);
        
        [MethodImpl(Inline)]
        Identifications(params V[] src)
        {
            values = new List<V>(src.Length);
            Include(src);
        }

        public void Include(params V[] src)
            => values?.AddRange(src);

        public bool Contains(string id)
            => denullify(values).Any(v => v.Identifier == id);

        public int Count
            => denullify(values).Count;

        IEnumerator<V> IEnumerable<V>.GetEnumerator()
            => denullify(values).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => denullify(values).GetEnumerator();

    }
}