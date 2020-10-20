//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
// Original   : ValueStringBuilder in runtime library
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Buffers;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

	[ApiDataType("text.builders.chars")]
    public ref struct CharStringBuilder
	{
		char[] _Pooled;

		Span<char> _Buffer;

		int _pos;

        [MethodImpl(Inline)]
        public static CharStringBuilder create(Span<char> buffer)
        {
            var dst = new CharStringBuilder();
            dst._Pooled = null;
            dst._Buffer = buffer;
            dst._pos = 0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStringBuilder create(int capacity)
        {
            var dst = new CharStringBuilder();
			dst._Pooled = ArrayPool<char>.Shared.Rent(capacity);
			dst._Buffer = dst._Pooled;
			dst._pos = 0;
            return dst;
        }

		public int Length
		{
			[MethodImpl(Inline)]
			get => _pos;

			[MethodImpl(Inline)]
			set => _pos = value;
		}

		public int Capacity
		{
			[MethodImpl(Inline)]
            get => _Buffer.Length;
		}

		[MethodImpl(Inline)]
		public void EnsureCapacity(int capacity)
		{
			if (capacity > Capacity)
				Grow(capacity - _pos);
		}

		public unsafe ref char GetPinnableReference(bool terminate)
		{
			if (terminate)
			{
				EnsureCapacity(Length + 1);
				seek(_Buffer, (uint)Length) = AsciNull.Literal;
			}
			return ref pinnable(_Buffer);
		}

		public ref char this[uint index]
		{
		    [MethodImpl(Inline)]
			get => ref seek(_Buffer, index);
		}

		public string Render()
		{
			string result = slice(_Buffer, 0, _pos).ToString();
			Dispose();
			return result;
		}

		public Span<char> Data
		{
		    [MethodImpl(Inline)]
			get => _Buffer;
		}

		public unsafe ReadOnlySpan<char> AsSpan(bool terminate)
		{
			if (terminate)
			{
				EnsureCapacity(Length + 1);
				seek(_Buffer,(uint)Length) = '\0';
			}
			return _Buffer.Slice(0, _pos);
		}

		[MethodImpl(Inline)]
		public ReadOnlySpan<char> AsSpan()
            => slice(_Buffer,0, _pos);

		[MethodImpl(Inline)]
		public ReadOnlySpan<char> AsSpan(int start)
            => slice(_Buffer, start, _pos - start);

		[MethodImpl(Inline)]
        public ReadOnlySpan<char> AsSpan(int start, int length)
            => slice(_Buffer, start, length);

		public bool TryCopyTo(Span<char> destination, out int charsWritten)
		{
			if (slice(_Buffer, 0, _pos).TryCopyTo(destination))
			{
				charsWritten = _pos;
				Dispose();
				return true;
			}
            else
            {
                charsWritten = 0;
                Dispose();
                return false;
            }
		}

		[MethodImpl(Inline)]
        static ReadOnlySpan<char> span(string src)
            => src.AsSpan();

		public void Insert(int index, string src)
		{
			var srclen = src.Length;
			if (MustGrow(srclen))
				Grow(srclen);

			var length2 = _pos - index;
			slice(_Buffer, index, length2).CopyTo(slice(_Buffer, index + srclen));
            span(src).CopyTo(slice(_Buffer, index));
			_pos += srclen;
		}

		[MethodImpl(Inline)]
		public unsafe void AppendUnchecked(char src)
		{
			seek(_Buffer, (uint)_pos) = src;
			_pos++;
		}

		[MethodImpl(Inline)]
		public unsafe void Append(char src)
		{
			var pos = _pos;
			if (pos < Capacity)
                AppendUnchecked(src);
			GrowAndAppend(src);
		}


		[MethodImpl(Inline)]
        public void AppendLeadUnchecked(string src)
        {
            seek(_Buffer,(uint)_pos) = src[0];
            _pos++;
        }

		[MethodImpl(Inline)]
		public unsafe void Append(string src)
		{
			var pos = _pos;
		    var srclen = src.Length;
        	if (srclen == 1 && pos < Capacity)
                AppendLeadUnchecked(src);
            else
            {
                if (MustGrow(srclen))
                    Grow(srclen);

                AppendUnchecked(src);
            }
		}

		[MethodImpl(Inline)]
        public void AppendUnchecked(string src)
        {
			var srclen = src.Length;
            span(src).CopyTo(slice(_Buffer, _pos));
			_pos += srclen;
        }

		[MethodImpl(Inline)]
        public unsafe void AppendUnchecked(char src, int count)
		{
			var segment = slice(_Buffer, _pos, count);
			for (var i = 0u; i<segment.Length; i++)
				seek(segment, i) = src;
			_pos += count;

        }

		[MethodImpl(Inline)]
        public unsafe void Append(char src, int count)
		{
			if (MustGrow(count))
				Grow(count);

            AppendUnchecked(src,count);
		}

		[MethodImpl(Inline)]
		public unsafe void AppendUnchecked(char* src, int srclen)
		{
			var seg = slice(_Buffer, _pos, srclen);
            var seglen = seg.Length;
			for (var i = 0u; i<seglen; i++)
				seek(seg,i) = *(src++);
			_pos += srclen;
        }

		[MethodImpl(Inline)]
		public unsafe void Append(char* src, int srclen)
		{
			int pos = _pos;

            if (MustGrow(srclen))
				Grow(srclen);

            AppendUnchecked(src, srclen);
		}

        [MethodImpl(Inline)]
        bool MustGrow(int srclen)
            => _pos > Capacity - srclen;

        public void Append(ReadOnlySpan<char> src)
		{
			int pos = _pos;
            var srclen = src.Length;
			if (pos > Capacity - srclen)
				Grow(srclen);

			src.CopyTo(slice(_Buffer, _pos));
			_pos += src.Length;
		}

		[MethodImpl(Inline)]
		public Span<char> AppendSpan(int srclen)
		{
			int pos = _pos;
			if (pos > Capacity - srclen)
				Grow(srclen);
			_pos = pos + srclen;
			return slice(_Buffer, pos, srclen);
		}

		[MethodImpl(NotInline)]
		private void GrowAndAppend(char c)
		{
			Grow(1);
			Append(c);
		}

		[MethodImpl(NotInline)]
		private void Grow(int amount)
		{
			var rented = ArrayPool<char>.Shared.Rent(Math.Max(_pos + amount, Capacity * 2));
			_Buffer.CopyTo(rented);
			var @return = _Pooled;
			_Buffer = (_Pooled = rented);
			if (@return != null)
				ArrayPool<char>.Shared.Return(@return, false);
		}

		[MethodImpl(Inline)]
		public void Dispose()
            => Release(ref this);

		[MethodImpl(Inline)]
        static void Release(ref CharStringBuilder builder)
        {
			var @return = builder._Pooled;
			builder = default(CharStringBuilder);
			if (@return != null)
				ArrayPool<char>.Shared.Return(@return, false);
        }
	}
}