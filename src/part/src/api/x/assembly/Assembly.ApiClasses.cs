//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XApi
    {
        [Op]
        public static Index<SymLiteral> ApiClasses(this Assembly src)
            => SymbolicLiterals.symbolic(src.Enums().Tagged<ApiClassAttribute>());
    }
}