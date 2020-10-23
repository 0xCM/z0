//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Buffers;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    public ref struct CharBuffer
    {
		Span<char> _Buffer;

		uint Index;

        [MethodImpl(Inline)]
        public static CharBuffer create(Span<char> buffer)
        {
            var dst = new CharBuffer();
            dst._Buffer = buffer;
            dst.Index = 0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharBuffer create(uint capacity)
        {
            var dst = new CharBuffer();
			dst._Buffer = alloc<char>(capacity);
			dst.Index = 0;
            return dst;
        }

		public uint Capacity
		{
			[MethodImpl(Inline)]
            get => (uint)_Buffer.Length;
		}

		public ref char this[uint index]
		{
		    [MethodImpl(Inline)]
			get => ref seek(_Buffer, index);
		}

		public uint Render(Span<char> dst)
		{
			var src = slice(_Buffer, 0, Index);
            src.CopyTo(dst);
            Reset();
			return (uint)src.Length;
		}

		[MethodImpl(Inline)]
		public unsafe uint Append(char src)
		{
			seek(_Buffer, (uint)Index) = src;
			return ++Index;
		}

		[MethodImpl(Inline)]
        public uint AppendLead(string src)
        {
            seek(_Buffer,(uint)Index) = src[0];
			return ++Index;
        }

		[MethodImpl(Inline)]
        public uint Append(string src)
        {
			var srclen = (uint)src.Length;
            span(src).CopyTo(slice(_Buffer, Index));
			Index += srclen;
            return Index;
        }

		[MethodImpl(Inline)]
        public unsafe uint Append(char src, uint count)
		{
			var segment = slice(_Buffer, Index, count);
			for (var i = 0u; i<segment.Length; i++)
				seek(segment, i) = src;
			Index += count;
            return Index;
        }

		[MethodImpl(Inline)]
		public unsafe uint Append(char* src, uint srclen)
		{
			var seg = slice(_Buffer, Index, srclen);
            var seglen = seg.Length;
			for (var i = 0u; i<seglen; i++)
				seek(seg,i) = *(src++);
			Index += srclen;
            return Index;
        }

		[MethodImpl(Inline)]
        public uint Append(ReadOnlySpan<char> src)
		{
			var pos = Index;
            var srclen = src.Length;

			src.CopyTo(slice(_Buffer, Index));
			Index += (uint)src.Length;
            return Index;
		}

        public void Reset()
        {
            _Buffer.Clear();
            Index = 0;
        }
    }
}