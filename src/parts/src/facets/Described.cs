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
    /// Characterizes type that defines a Description facet
    /// </summary>
    public interface IDescribed
    {
        string Description {get;}
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic type that defines a Description facet
    /// </summary>
    public interface IDescribed<F> : IDescribed, IFacet<string>
        where F : IDescribed<F>
    {
        string IDescribed.Description 
            => DescriptionAttribute.TargetDescription<F>();

        string IFacet.FacetName 
            => nameof(Description);

        string IFacet<string>.FacetValue 
            => Description;
    }

    public readonly struct Described : IDescribed<Described>
    {
        public string Label {get;}

        public static Described Attributed 
        {
            [MethodImpl(Inline)]
            get => new Described(LabelAttribute.TargetLabel<Described>());
        }
        
        [MethodImpl(Inline)]
        public static Described From(string src)
            => new Described(src);
        
        [MethodImpl(Inline)]
        public static implicit operator string(Described src)
            => src.Label;

        [MethodImpl(Inline)]
        public static implicit operator Described(string src)
            => From(src);

        [MethodImpl(Inline)]
        public Described(string label)
        {
            Label = label;
        }    
    }    
}