//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Table
    {
        [Op]
        public static TableFields fields(Type type)
        {
            if(!type.IsStruct() || type.IsPrimitive)
                return TableFields.Empty;

            var declared = type.Fields();
            var count = declared.Length;
            var buffer = alloc<TableField>(count);

            map(declared, buffer);

            return new TableFields(buffer);
        }

        [Op]
        public static TableFields fields(Type src, bool recurse)
        {
            var collected = root.list<TableField>();
            ushort j = 0;
            if(src.IsStruct() && !src.IsPrimitive)
            {
                var defs = @readonly(src.DeclaredInstanceFields());
                var count = defs.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var def = ref skip(defs,i);
                    var dst = new TableField();
                    map(def, j++, ref dst);
                    var ft = def.FieldType;
                    if(ft.IsStruct() && !ft.IsPrimitive && recurse)
                    {
                        var subfields = fields(ft, recurse);
                        collected.AddRange(subfields.Storage);
                    }
                }
            }

            var final = collected.ToArray();
            var fCount = final.Length;
            ref var f = ref first(span(final));
            for(ushort index = 0; index<fCount; index++)
                seek(f,index).Index = index;

            return final;
        }
    }
}