//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class ClassArtifact : TypeArtifact<ClassArtifact,ClassFacets>
    {
        public static ClassArtifact Define(string ns, string name, ClassFacets facets)
            => new ClassArtifact(ns,name, facets);

        public static ClassArtifact Define(string name, ClassFacets facets)
            => new ClassArtifact(string.Empty,name, facets);

        public ClassArtifact(string ns, string name, ClassFacets facets)
            : base(ns, name, facets)
        {}        
    }
}