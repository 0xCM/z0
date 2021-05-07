//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.Vector128;
    using static Part;
    using static memory;

    /// <summary>
    /// A reference to a (hopefully) interned or resource string
    /// </summary>
    [ApiHost]
    public readonly struct StringRef : ITextual
    {
        readonly Vector128<ulong> Data;

        [MethodImpl(Inline), Op]
        public static void create(ReadOnlySpan<string> src, Span<StringRef> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = create(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static StringRef[] create(ReadOnlySpan<string> src)
        {
            var dst = sys.alloc<StringRef>(src.Length);
            create(src,dst);
            return dst;
        }

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='string'/>
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="user">The user data, if any</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef create(string src)
            => new StringRef((ulong)pchar(src), (uint)src.Length);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='MemoryAddress'/> and memory size
        /// </summary>
        /// <param name="address">The reference address</param>
        /// <param name="length">The size, in bytes, of the segment</param>
        [MethodImpl(Inline), Op]
        public static StringRef create(MemoryAddress address, ByteSize size)
            => new StringRef(address, size*2);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='MemorySeg'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static StringRef create(MemorySeg src)
            => new StringRef(Create(src.BaseAddress, (ulong)src.Length));

        /// <summary>
        /// Formats the source argument according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0)
            => text.format(pattern.Format(), arg0.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1)
            => text.format(pattern.Format(), arg0.Format(), arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in StringRef arg0, in StringRef arg1)
            => text.format(pattern, arg0, arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in string arg0, in StringRef arg1)
            => text.format(pattern, arg0, arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <param name="arg2">The third pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1, in StringRef arg2)
            => text.format(pattern.Format(), arg0.Format(), arg1.Format(), arg2.Format());

        [Op]
        public static string join(string delimiter, params StringRef[] refs)
        {
            var dst = text.build();
            var src = span(refs);
            var count = src.Length;

            for(var i=0u; i<count; i++)
            {
                var s = skip(src,i).Text;
                dst.Append(s);
                if(i != count - 1)
                    dst.Append(delimiter);
            }

            return dst.ToString();
        }

        /// <summary>
        /// Reveals the character data identified by a string reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> view(in StringRef src)
            => cover<char>(src.BaseAddress.Pointer<char>(), (uint)src.Length);

        /// <summary>
        /// Reveals the character data identified by a string reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> bytes(in StringRef src)
            => memory.bytes(view(src));

        [Op]
        public static void store(in StringRef src, ref char dst, uint offset = 0)
        {
            var c = view(src);
            var k = c.Length;
            for(uint i=0, o = offset; i<k; i++, o++)
                memory.seek(dst,o) = memory.skip(c,i);
        }

        /// <summary>
        /// Reveals the character data identified by a string reference as a mutable span
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        static unsafe Span<char> edit(in StringRef src)
            => memory.cover<char>(src.BaseAddress.Pointer<char>(), (uint)src.Length);

        [MethodImpl(Inline), Op]
        static Vector128<ulong> pack(MemoryAddress address, uint length)
            => Create((ulong)address, (ulong)length);

        [MethodImpl(Inline), Op]
        static void unpack(ulong src, out uint length, out uint user)
        {
            length = (uint)src;
            user  = (uint)(src >> 32);
        }

        [MethodImpl(Inline), Op]
        static MemoryAddress location(Vector128<ulong> src)
            => src.GetElement(0);

        [MethodImpl(Inline)]
        StringRef(in MemorySeg src)
            => Data = Create((ulong)src.BaseAddress, (ulong)src.Length);

        [MethodImpl(Inline)]
        StringRef(MemoryAddress address, uint length)
            => Data = pack(address, length);

        [MethodImpl(Inline)]
        StringRef(Vector128<ulong> data)
            => Data = data;

        [MethodImpl(Inline)]
        public StringRef(Cell128 data)
            => Data = data;

        public Vector128<ulong> Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        static uint length(Vector128<ulong> src)
        {
            unpack(src.GetElement(1), out var size, out var _);
            return size/memory.scale<char>();
        }

        /// <summary>
        /// The length of the represented string
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)length(Data);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Length;
        }

        /// <summary>
        /// The string content presented as a readonly span
        /// </summary>
        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => view(this);
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => View.ToString();
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => location(Data);
        }

        public ref readonly char this[int index]
        {
            [MethodImpl(Inline)]
            get => ref memory.skip(View,(uint)index);
        }


        /// <summary>
        /// The string content presented as a mutable span
        /// </summary>
        public Span<char> Edit
        {
            [MethodImpl(Inline)]
            get => edit(this);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length != 0;
        }

        public StringRef Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public static StringRef Empty
        {
            [MethodImpl(Inline)]
            get => empty();
        }

        [MethodImpl(Inline), Op]
        public static StringRef empty()
            => new StringRef(MemorySeg.Empty);

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(MemorySeg src)
            => new StringRef(src);

        [MethodImpl(Inline)]
        public static implicit operator string(StringRef src)
            => src.Text;

        [MethodImpl(Inline)]
        public static unsafe implicit operator StringRef(string src)
            => create(src);
   }
}