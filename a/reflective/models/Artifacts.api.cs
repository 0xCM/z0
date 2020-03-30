//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class Artifacts
    {   
        public static ConstFieldArtifact constfield(string name, string typename, object constval, FieldFacets facets = FieldFacets.Const | FieldFacets.Public)
            => ConstFieldArtifact.Define(name, typename, constval, facets);

        public static ConstFieldArtifact field(string name, string typename, FieldFacets facets = FieldFacets.Public)
            => ConstFieldArtifact.Define(name, typename, null, facets);

        public static ClassArtifact @class(string @namespace, string name, ClassFacets facets = ClassFacets.Public)
            => ClassArtifact.Define(@namespace,name,facets);

        public static ClassArtifact @class(string name, ClassFacets facets = ClassFacets.Public)
            => ClassArtifact.Define(name,facets);

        public static StructArtifact @struct(string @namespace, string name, StructFacets facets = StructFacets.Public)
            => StructArtifact.Define(@namespace,name,facets);

        public static StructArtifact @struct(string name, StructFacets facets = StructFacets.Public)
            => StructArtifact.Define(name,facets);
    }
}