//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Literals
    {
        [Op]
        public static Span<char> chars(Type src)
        {
            var fields = @readonly(src.Fields());
            var count = fields.Length;
            var dst = span<char>(count);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields, i);
                if(field.FieldType.MetadataToken == typeof(char).MetadataToken)
                {
                    seek(dst,counter) = (char)field.GetRawConstantValue();
                    counter++;
                }
            }

            return slice(dst,0, counter);
        }
    }
}