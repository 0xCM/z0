//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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
}