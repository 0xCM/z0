//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class FacetX
    {

        public static CodeFacets Normalize(this MemberFacets facets)
            => (CodeFacets)facets;

        public static CodeFacets Normalize(this FieldFacets facets)
            => (CodeFacets)facets;

        public static CodeFacets Normalize(this ClassFacets facets)
            => (CodeFacets)facets;

        public static CodeFacets Normalize(this TypeFacets facets)
            => (CodeFacets)facets;

        public static bool IsStatic(this CodeFacets facets)
            => (facets & Z0.CodeFacets.Static) != 0;

        public static bool IsPublic(this CodeFacets facets)
            => (facets & Z0.CodeFacets.Public) != 0;

        public static bool IsConst(this CodeFacets facets)
            => (facets & Z0.CodeFacets.Const) != 0;
    }
}