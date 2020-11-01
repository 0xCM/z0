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

    partial struct Cmd
    {
        [Op, Closures(UInt64k)]
        public static CmdSpec untype<T>(in T spec)
            where T : struct
        {
            var t = typeof(T);
            var fields = ClrQuery.fields(t);
            var count = fields.Length;
            var reflected = alloc<ClrFieldValue>(count);
            ClrQuery.values(spec, fields, reflected);
            var buffer = alloc<CmdArg>(count);
            var target = span(buffer);
            var source = @readonly(reflected);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(source,i);
                seek(target,i) = new CmdArg(fv.Field.Name, fv.Value?.ToString() ?? EmptyString);
            }
            return new CmdSpec(Cmd.id(t), buffer);
        }
    }
}