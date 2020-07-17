//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;

    using static Konst;
    using static z;

    partial class Enums
    {
        [MethodImpl(Inline), Op]
        public static EnumLiterals index(Type @enum)
        {
            var nk = @enum.GetEnumUnderlyingType().NumericKind();
            var ek = Enums.@base(nk);
            var type = Enums.@base(@enum);
            var fields = span(@enum.LiteralFields());
            var count = fields.Length;
            var buffer = sys.alloc<EnumLiteral>(count);
            var dst = span(buffer);
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var scalar = Variant.define(field.GetRawConstantValue(), nk);
                seek(dst,i) = new EnumLiteral(field, nk, i, field.Name, scalar);
            }
            return new EnumLiterals(buffer);
        }
    }
}