//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;
    
    public static class NamedValue
    {
        [MethodImpl(Inline)]
        public static NamedValue<V> Define<V>(string name, V value)
            => new NamedValue<V>(name,value);

        public static IDictionary<string,V> ToDictionary<V>(this IEnumerable<NamedValue<V>> src)
            => src.Select(x => (x.Name, x.Value)).ToDictionary();

        public static HashSet<string> Names<V>(this IEnumerable<NamedValue<V>> src)
            => src.Select(x => x.Name).ToHashSet();

    }

    /// <summary>
    /// Names a value
    /// </summary>
    public readonly struct NamedValue<V> 
    {
        /// <summary>
        /// The name of the value
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The named value
        /// </summary>
        public readonly V Value;

        [MethodImpl(Inline)]
        public static implicit operator NamedValue<V>((string name, V value) src)
            => new NamedValue<V>(src);

        [MethodImpl(Inline)]
        public static implicit operator (string name, V value)(NamedValue<V> src)
            => (src.Name, src.Value);
        
        [MethodImpl(Inline)]
        public NamedValue(string name, V value)
        {
            this.Name = name;
            this.Value = value;
        }

        [MethodImpl(Inline)]
        public NamedValue((string name, V value) nv)
        {
            this.Name = nv.name;
            this.Value = nv.value;
        }        

        [MethodImpl(Inline)]
        public void Deconstruct(out string name, out V value) 
        {
            name = Name;
            value = Value;
        }

        public string Format()
            => $"{Name} = {Value}";

        public override string ToString()
            => Format();
    }
}