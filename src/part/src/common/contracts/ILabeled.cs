//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes type that defines a Label facet
    /// </summary>
    public interface ILabeled : IFacet<string,string>
    {
        string Label {get;}

        string IFacet<string,string>.Value
            => Label;

        string IKeyed<string>.Key
            => Label;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic type that defines a label facet
    /// </summary>
    public interface ILabeled<F> : ILabeled
        where F : ILabeled<F>
    {
        string ILabeled.Label
            => LabelAttribute.TargetLabel<F>();
    }
}