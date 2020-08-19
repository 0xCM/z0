//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableSpec<T>
    {
        public readonly FullTypeName Type;

        public readonly FieldSpec[] Fields;

        [MethodImpl(Inline)]
        public TableSpec(FieldSpec[] fields)
        {
            Type = typeof(T).AssemblyQualifiedName;;
            Fields = fields;
        }
    }
}