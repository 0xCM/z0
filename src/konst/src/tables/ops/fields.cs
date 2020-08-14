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

    using static Z0.Data.Table;
    
    partial struct Table
    {
        [Op]
        public static TableFields fields(Type type)
        {
            var declared = type.DeclaredInstanceFields();
            var src = span(declared);
            var count = declared.Length;
            var buffer = alloc<TableField>(declared.Length);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = field(skip(src,i));
            return new TableFields(buffer);
        }

        [Op]
        public static TableFields<F> fields<F,T>()
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var t = typeof(T);
            var f = fields(t);
            var l = literals<F>();
            var v = l.View;
            var buffer = alloc<TableField<F>>(v.Length);
            var dst = span(buffer);
            for(var i=0u; i<dst.Length; i++)
            {
                ref readonly var litVal = ref l[i];
                var litName = l.Name(i);
                var ff = f[l.Name(i)];
                if(ff.IsSome())
                    seek(dst,i) = field<F,T>(litVal,ff.Value.Definition);
            }
            return buffer;
        }
    }
}