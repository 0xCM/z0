//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableSpec
    {
        public readonly FullTypeName Type;

        public readonly FieldSpec[] Fields;

        [MethodImpl(Inline)]
        public TableSpec(FullTypeName type, params FieldSpec[] fields)
        {
            Type = type;
            Fields = fields;
        }
    }
}