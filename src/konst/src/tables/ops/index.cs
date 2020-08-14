//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;
    using Z0.Data;

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static LiteralFields literals(Type src)
            => new LiteralFields(src.LiteralFields());

        [Op]
        public static ReadOnlySpan<EnumLiteralRecord> literals(PartId part, Type src)
            => EnumLiteralRecords.from(part,src);
    }
}