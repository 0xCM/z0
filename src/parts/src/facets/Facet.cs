//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Facet : IFacet
    {
        public string FacetName {get;}

        public object FacetValue {get;}

        [MethodImpl(Inline)]
        public static implicit operator Facet((string name, object value) src)
            => new Facet(src.name, src.value);

        [MethodImpl(Inline)]
        public Facet(string name, object value)
        {
            FacetName = name;
            FacetValue = value;
        }
    }

    public readonly struct Facet<V> : IFacet<V>
    {
        public string FacetName {get;}

        public V FacetValue {get;}

        [MethodImpl(Inline)]
        public static implicit operator Facet(Facet<V> src)
            => new Facet(src.FacetName, src.FacetValue);

        [MethodImpl(Inline)]
        public static implicit operator Facet<V>((string name, V value) src)
            => new Facet<V>(src.name, src.value);
        
        [MethodImpl(Inline)]
        public Facet(string name, V value)
        {
            FacetName = name;
            FacetValue = value;
        }        
    }    
}