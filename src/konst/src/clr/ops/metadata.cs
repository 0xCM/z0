namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    partial struct Clr
    {
        /// <summary>
        /// Returns a <see cref='SegRef'/> to the cli metadata segment of the source
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe SegRef<byte> metaref(Assembly src)
        {
            if(src.TryGetRawMetadata(out var ptr, out var len))
                return memory.segref(ptr, len);
            else
                return SegRef<byte>.Empty;
        }

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe ref SegRef<byte> metaref(Assembly src, out SegRef<byte> dst)
        {
            src.TryGetRawMetadata(out var ptr, out var len);
            dst = memory.segref(ptr, len);
            return ref dst;
        }

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe ref ReadOnlySpan<byte> metaspan(Assembly src, out ReadOnlySpan<byte> dst)
        {
            src.TryGetRawMetadata(out var ptr, out var size);
            dst = memory.cover(ptr, size);
            return ref dst;
        }

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe ReadOnlySpan<byte> metaspan(Assembly src)
        {
            src.TryGetRawMetadata(out var ptr, out var size);
            return memory.cover(ptr, size);
        }
    }
}