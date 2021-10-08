//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public enum RelationKind : byte
    {
        None,

        Dependency,

        Flow,

        Facet,

        Parent,

        Child,

        Parametric
    }

}