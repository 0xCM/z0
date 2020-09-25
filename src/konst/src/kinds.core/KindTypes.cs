//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly struct KindTypes
    {
        public static KindTypes service()
            => new KindTypes(0);

        readonly Type[] Nested;

        KindTypes(int i)
        {
            Nested = typeof(Kinds).GetNestedTypes();
        }
    }
}