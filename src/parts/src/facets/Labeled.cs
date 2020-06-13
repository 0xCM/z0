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
    /// Characterizes type that defines a Label facet
    /// </summary>
    public interface ILabeled
    {
        string Label {get;}
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic type that defines a Lable facet
    /// </summary>
    public interface ILabeled<F> : ILabeled, IFacet<string>
        where F : ILabeled<F>
    {
        string ILabeled.Label 
            => LabelAttribute.TargetLabel<F>();

        string IFacet.FacetName 
            => nameof(Label);
        
        string IFacet<string>.FacetValue 
            => Label;
    }

    public readonly struct Labeled : ILabeled<Labeled>
    {
        public string Label {get;}

        public static Labeled Attributed 
        {
            [MethodImpl(Inline)]
            get => new Labeled(LabelAttribute.TargetLabel<Labeled>());
        }
        
        [MethodImpl(Inline)]
        public static Labeled From(string src)
            => new Labeled(src);
        
        [MethodImpl(Inline)]
        public static implicit operator string(Labeled src)
            => src.Label;

        [MethodImpl(Inline)]
        public static implicit operator Labeled(string src)
            => From(src);

        [MethodImpl(Inline)]
        public Labeled(string label)
        {
            Label = label;
        }    
    }
}