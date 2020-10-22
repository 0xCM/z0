//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.IO;

    using static Konst;
    using static z;

    partial struct Resources
    {
        [Op]
        public static unsafe ResourceDescriptor[] descriptors(Assembly src)
        {
            var resnames = Resources.names(src);
            var count = resnames.Length;
            var buffer = alloc<ResourceDescriptor>(count);
            var target = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var name = ref skip(resnames, i);
                var stream = (UnmanagedMemoryStream)src.GetManifestResourceStream(name);
                ref var dst = ref seek(target,i);
                dst = new ResourceDescriptor(name, stream.PositionPointer, (uint)stream.Length);
            }
            return buffer;
        }

        /// <summary>
        /// Reveals the data represented by a <see cref='ResourceDescriptor'/>
        /// </summary>
        /// <param name="src">The source descriptor</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> data(in ResourceDescriptor src)
            => MemView.view(src.Address, src.Size);
    }
}