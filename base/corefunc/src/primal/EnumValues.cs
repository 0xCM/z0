//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;
    
    /// <summary>
    /// Represents the collection of enumeration literals defined by an enum
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    public readonly struct EnumValues<E>
        where E : Enum
    {
        internal static EnumValues<E> TheOnly => default;

        static readonly E[] Cache
            = typeof(E).GetEnumValues().AsQueryable().Cast<E>().Distinct().ToArray();

        static readonly Dictionary<string, E> NameIndex
            = Cache.Select(e => (e.ToString(), e)).ToDictionary();

        static readonly Dictionary<string,NamedValue<E>> NameValueCache 
            = NameIndex.Select(x => (x.Key,new NamedValue<E>(x.Key, x.Value))).ToDictionary();


        [MethodImpl(Inline)]
        internal E[] ToArray()
            => Cache;

        [MethodImpl(Inline)]
        public Option<E> Parse(string src)
        {
            if(NameIndex.TryGetValue(src, out E dst))
                return dst;

            if(Enum.TryParse(typeof(E), src, true, out object result))
                return (E)result;
            return default;
        }
        
        [MethodImpl(Inline)]
        public ReadOnlySpan<E> ToSpan()
            => Cache;

        public IReadOnlyDictionary<string,NamedValue<E>> NamedValues
        {
            [MethodImpl(Inline)]
            get => NameValueCache;
        }
        
        public IEnumerable<E> Enumerate()
            => new EnumValueEnumerator<E>();         
    }

    /// <summary>
    /// Represents the collection of enumeration literals defined by 
    /// an enum of specified scalar
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    /// <typeparam name="T">The scalar type</typeparam>
    public readonly struct EnumValues<E,T>
        where E : Enum
        where T : unmanaged

    {
        internal static EnumValues<E,T> TheOnly => default;

        static EnumValues<E> Values => EnumValues<E>.TheOnly;

        static readonly Dictionary<E,T> ScalarIndex
            = Values.ToArray().Select(e => (e, (T)Convert.ChangeType(e,typeof(T)))).ToDictionary();
        
        static readonly NamedValue<T>[] NamedScalarCache 
            = ScalarIndex.Select(x => new NamedValue<T>(x.Key.ToString(), x.Value)).ToArray();

        [MethodImpl(Inline)]
        public static implicit operator EnumValues<E>(EnumValues<E,T> src)
            => Values;

        public ReadOnlySpan<E> ValueSpan
        {
            [MethodImpl(Inline)]
            get => EnumValues<E>.TheOnly.ToSpan();
        }

        public ReadOnlySpan<T> ScalarSpan
        {
            [MethodImpl(Inline)]
            get => ScalarIndex.Values.ToArray();
        }
    
        [MethodImpl(Inline)]
        public Option<E> Parse(string src)
            => Values.Parse(src);

        [MethodImpl(Inline)]
        public T ToScalar(E src)
        {
            if(ScalarIndex.TryGetValue(src, out T dst))
                return dst;
            else
                return (T)Convert.ChangeType(src,typeof(T));
        }

        public IReadOnlyDictionary<string,NamedValue<E>> NamedValues
        {
            [MethodImpl(Inline)]
            get => Values.NamedValues;
        }

        public ReadOnlySpan<NamedValue<T>> NamedScalars
        {
            [MethodImpl(Inline)]
            get => NamedScalarCache;
        }
    }
}