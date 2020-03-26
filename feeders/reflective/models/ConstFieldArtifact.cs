//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a constant field
    /// </summary>
    public sealed class ConstFieldArtifact : MemberArtifact<ConstFieldArtifact, FieldFacets>
    {
        public static ConstFieldArtifact Define(string name, string typename, object constval, FieldFacets facets)
            => new ConstFieldArtifact(name, typename, constval, facets);
        
        ConstFieldArtifact(string name, string typename, object constval, FieldFacets facets)
            : base(name, facets)
        {
            this.ConstValue = constval;
            this.TypeName = typename;
        }

        public Option<object> ConstValue {get;}

        public string TypeName {get;}
    }
}