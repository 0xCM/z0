//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Part;
    using static memory;

    partial struct ImageMaps
    {
        [Op]
        public static Index<ProcessModuleRow> modules(Process src)
        {
            var modules = @readonly(src.Modules.Cast<ProcessModule>().Array());
            var count = modules.Length;
            var buffer = alloc<ProcessModuleRow>(count);
            fill(modules, buffer);
            // var dst = span(buffer);
            // for(var i=0u; i<count; i++)
            //     fill(skip(modules,i), ref seek(dst, i));
            return buffer;
        }
    }
}