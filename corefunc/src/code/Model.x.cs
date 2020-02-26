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
        public static bool IsStatic(this IMemberInfo model)
            => model.Facets.Normalize().IsStatic();

        public static bool IsStatic(this ITypeInfo model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsPublic(this ITypeInfo model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsPublic(this IMemberInfo model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsStruct(this ITypeInfo model)
            => model is StructModel;

        public static bool IsConst(this ITypeInfo model)
            => model.Facets.Normalize().IsConst();

        public static bool IsConst(this IMemberInfo model)
            => model.Facets.Normalize().IsConst();

        public static bool IsClass(this ITypeInfo model)
            => model is ClassModel;       
    }
}