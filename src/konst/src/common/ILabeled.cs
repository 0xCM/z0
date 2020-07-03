//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
}