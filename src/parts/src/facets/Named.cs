//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes type that defines a Name facet
    /// </summary>
    public interface INamed
    {
        string Name {get;}
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic type that defines a Name facet
    /// </summary>
    public interface INamed<F> : INamed, IFacet<string>
        where F : INamed<F>
    {
        string INamed.Name 
            => NameAttribute.TargetName<F>();

        string IFacet.FacetName 
            => nameof(Name);
        
        string IFacet<string>.FacetValue 
            => Name;
    }

    public readonly struct Named : INamed<Named>
    {
        public string Label {get;}

        public static Named Attributed 
        {
            [MethodImpl(Inline)]
            get => new Named(LabelAttribute.TargetLabel<Named>());
        }
        
        [MethodImpl(Inline)]
        public static Named From(string src)
            => new Named(src);
        
        [MethodImpl(Inline)]
        public static implicit operator string(Named src)
            => src.Label;

        [MethodImpl(Inline)]
        public static implicit operator Named(string src)
            => From(src);

        [MethodImpl(Inline)]
        public Named(string label)
        {
            Label = label;
        }    
    }    
}