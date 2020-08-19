//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;
    using static Konst;

    public readonly struct TableBuilderLiterals
    {
        public const TypeAttributes TableAttributes
            = TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.ExplicitLayout | TypeAttributes.Serializable | TypeAttributes.AnsiClass;
    }
}