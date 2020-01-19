//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class CodeModel
    {
        public static FieldModel constfield(string name, string typename, object constval, FieldFacets facets = FieldFacets.Const | FieldFacets.Public)
            => FieldModel.Define(name, typename, constval, facets);

        public static FieldModel field(string name, string typename, FieldFacets facets = FieldFacets.Public)
            => FieldModel.Define(name, typename, null, facets);

        public static ClassModel @class(string @namespace, string name, ClassFacets facets = ClassFacets.Public)
            => ClassModel.Define(@namespace,name,facets);

        public static ClassModel @class(string name, ClassFacets facets = ClassFacets.Public)
            => ClassModel.Define(name,facets);

        public static StructModel @struct(string @namespace, string name, StructFacets facets = StructFacets.Public)
            => StructModel.Define(@namespace,name,facets);

        public static StructModel @struct(string name, StructFacets facets = StructFacets.Public)
            => StructModel.Define(name,facets);
    }
}