//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static Index<ResDescriptors> descriptors(ReadOnlySpan<Assembly> src)
        {
            var dst = root.list<ResDescriptors>();
            root.iter(src, component => dst.Add(descriptors(component)));
            return dst.ToArray();
        }

        [MethodImpl(Inline), Op]
        public static ResDescriptors descriptors(Assembly src, utf8 match)
            => new ResDescriptors(src, collect(src, match));

        [MethodImpl(Inline), Op]
        public static ResDescriptors descriptors(Assembly src)
            => ResDescriptors.from(src);

        [Op]
        static unsafe Index<ResDescriptor> collect(Assembly src, utf8? match = null)
        {
            root.require(src != null, () => "Argument NULL");
            var resnames = @readonly(Resources.names(src, match));
            var count = resnames.Length;
            if(count == 0)
                return sys.empty<ResDescriptor>();

            var buffer = alloc<ResDescriptor>(count);
            var target = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var name = ref skip(resnames, i);
                var stream = (UnmanagedMemoryStream)src.GetManifestResourceStream(name);
                seek(target,i) = descriptor(name, stream.PositionPointer, (uint)stream.Length);
            }
            return buffer;
        }
    }
}