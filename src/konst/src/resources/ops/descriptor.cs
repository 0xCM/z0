//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Resources
    {
        /// <summary>
        /// Defines a <see cref='ResDescriptor'/>
        /// </summary>
        /// <param name="name">The resource name</param>
        /// <param name="address">The memory location at which the resource content begins</param>
        /// <param name="size">The size of the resource, in bytes</param>
        [MethodImpl(Inline), Op]
        public static ResDescriptor descriptor(Name name, MemoryAddress address, ByteSize size)
            => new ResDescriptor(name, address, size);

        [Op]
        public static unsafe bool descriptor(Assembly src, string id, out ResDescriptor dst)
        {
            root.require(text.nonempty(id), () => $"The id given for {src} is null");
            root.require(src != null, () => $"The assembly for {id} is null");
            var resnames = Resources.names(src, id);
            if(resnames.Length != 1)
            {
                dst = ResDescriptor.Empty;
                return false;
            }
            else
            {
                var name = memory.first(resnames);
                var stream = (UnmanagedMemoryStream)src.GetManifestResourceStream(name);
                root.require(stream != null, () => $"The resource stream for {name} is null");
                dst = descriptor(name, stream.PositionPointer, stream.Length);
                return true;
            }
        }
    }
}