//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.IO;

    using static z;

    partial struct Resources
    {
        [Op]
        public static unsafe ResDescriptor[] descriptors(Assembly src, utf8? match = null)
        {
            root.require(src != null, () => "Argument NULL");
            var resnames = Resources.names(src, match);
            var count = resnames.Length;
            if(count == 0)
                return sys.empty<ResDescriptor>();

            var buffer = alloc<ResDescriptor>(count);
            var target = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var name = ref skip(resnames, i);
                var stream = (UnmanagedMemoryStream)src.GetManifestResourceStream(name);
                ref var dst = ref seek(target,i);
                dst = new ResDescriptor(name, stream.PositionPointer, (uint)stream.Length);
            }
            return buffer;
        }
    }
}