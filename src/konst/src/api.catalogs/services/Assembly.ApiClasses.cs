//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XTend
    {
        [Op]
        public static Index<SymbolicLiteral> ApiClasses(this Assembly src)
            => Symbols.symbolic(src.Enums().Tagged<ApiClassAttribute>());
    }
}