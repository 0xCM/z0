//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class CodeModelX
    {    
        public static bool IsStatic(this IMemberModel model)
            => model.Facets.Normalize().IsStatic();

        public static bool IsStatic(this ITypeModel model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsPublic(this ITypeModel model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsPublic(this IMemberModel model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsStruct(this ITypeModel model)
            => model is StructModel;

        public static bool IsConst(this ITypeModel model)
            => model.Facets.Normalize().IsConst();

        public static bool IsConst(this IMemberModel model)
            => model.Facets.Normalize().IsConst();

        public static bool IsClass(this ITypeModel model)
            => model is ClassModel;       
    }
}