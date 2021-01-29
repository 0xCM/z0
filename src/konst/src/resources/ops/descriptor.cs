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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ResDescriptor<T> descriptor<T>(Name name, MemoryAddress address, ByteSize size)
            => new ResDescriptor<T>(name, new MemorySegment(address, size));

        [Op]
        public static unsafe bool descriptor(Assembly src, string id, out ResDescriptor dst)
        {
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
                dst = descriptor(name, stream.PositionPointer, stream.Length);
                return true;
            }
        }
    }
}