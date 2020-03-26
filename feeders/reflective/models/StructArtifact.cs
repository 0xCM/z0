//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class StructArtifact : TypeArtifact<StructArtifact, StructFacets>
    {
        public static StructArtifact Define(string ns, string name, StructFacets facets)
            => new StructArtifact(ns,name, facets);

        public static StructArtifact Define(string name, StructFacets facets)
            => new StructArtifact(string.Empty,name, facets);

        public StructArtifact(string ns, string name, StructFacets facets)
            : base(ns, name, facets)
        {

        }        
    }
}