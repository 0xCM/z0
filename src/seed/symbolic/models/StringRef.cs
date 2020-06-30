//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    /// <summary>
    /// A string?
    /// </summary>
    [ApiHost]
    public readonly struct StringRef : ITextual, IReadOnlySpan<StringRef,char>
    {            
        readonly MemRef Ref;

        [MethodImpl(Inline), Op]
        public static StringRef empty()
            => new StringRef(MemRef.Empty);

        [MethodImpl(Inline), Op]
        public static unsafe string @string(StringRef src)
            => As.@string(src.Data);

        [MethodImpl(Inline), Op]
        public static StringRef create(string src)
            => new StringRef(new MemRef(MemoryAddress.from(src), src.Length));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> data(StringRef src)
            => view<char>(src.Ref);        
                
        [MethodImpl(Inline)]
        public static implicit operator string(StringRef src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(string src)
            => create(src);

        [MethodImpl(Inline)]
        public StringRef(in MemRef src)
            => Ref = src;

        /// <summary>
        /// The length of the represented string
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Ref.Length;
        }

        /// <summary>
        /// The string content presented as a span
        /// </summary>
        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => data(this);
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => @string(this);
        }

        public ref readonly char this[int index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Data,index);
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

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        public static StringRef Empty 
        {
            [MethodImpl(Inline)]
            get => empty();
        }
    }
}