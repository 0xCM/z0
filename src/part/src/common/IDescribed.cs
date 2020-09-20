//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
}