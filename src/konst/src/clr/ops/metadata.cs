namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Part;

    partial struct ClrQuery
    {
        /// <summary>
        /// Returns a <see cref='Ref'/> to the cli metadata segment of the source
        /// </summary>
        /// <param name="src">The source assembly</param>
        public static unsafe Ref<byte> metadata(Assembly src)
        {
            if(src.TryGetRawMetadata(out var ptr, out var len))
                return MemRefs.segment(ptr,len);
            else
                return Ref<byte>.Empty;
        }
    }
}