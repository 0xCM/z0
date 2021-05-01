//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct BitFields
    {
        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T store<T>(in BitfieldPart seg, in T src, ref T dst)
            where T : unmanaged
                => ref gbits.bitcopy(src, (byte)seg.FirstIndex, (byte)seg.Width, ref dst);

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ref T state<T>(ref Bitfield8<T> src)
            where T : unmanaged
                => ref @as<Bitfield8<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ref Bitfield8<T> store<T>(byte i0, byte i1, in T src, ref Bitfield8<T> dst)
            where T : unmanaged
        {
            var input = u8(src);
            var width = (byte)(i1 - i0 + 1);
            var replace = math.sll(input, width);
            dst.Overwrite(math.or((byte)dst, replace));
            return ref dst;
        }

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void store<T>(in BitfieldSegSpecs spec, T src, Span<T> dst)
            where T : unmanaged
        {
            var count = spec.FieldCount;
            for(var i=0u; i<count; i++)
                seek(dst,i) = read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T store<T>(in BitfieldSegSpecs spec, ReadOnlySpan<T> src, ref T dst)
            where T : unmanaged
        {
            var count = spec.FieldCount;
            for(var i=0u; i<count; i++)
                store<T>(skip(spec.Segments,i), skip(src,i), ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void store<E,W,T>(in BitfieldSpec<E,W> spec, T src, Span<T> dst)
            where E : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
        {
            var len = spec.Segments.Length;
            for(var i=0u; i<len; i++)
                seek(dst,i) = read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public static void store<S,T>(in BitfieldSegSpecs spec, in S src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            for(var i=0u; i<spec.FieldCount; i++)
                seek(dst,i) = read<S,T>(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public static ref T store<S,T>(in BitfieldPart segment, in S src, ref T dst)
            where S : unmanaged
            where T : unmanaged
                => ref gbits.bitcopy(@as<S,T>(src), (byte)segment.FirstIndex, (byte)segment.Width, ref dst);

        [MethodImpl(Inline)]
        public static ref S store<S,T>(in BitfieldPart segment, in S src, ref S dst)
            where S : unmanaged
            where T : unmanaged
        {
            var dstData = dst;
            gbits.bitcopy(src, (byte)segment.FirstIndex, (byte)segment.Width, ref dstData);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T store2<T>(in BitfieldSegSpecs spec, ReadOnlySpan<T> src, ref T data)
            where T : unmanaged
        {
            for(var i=0; i<spec.FieldCount; i++)
            {
                ref readonly var segment = ref skip(spec.Segments,i);
                gbits.bitcopy(skip(src,i), (byte)segment.FirstIndex, (byte)segment.Width, ref data);
            }
            return ref data;
        }
    }
}