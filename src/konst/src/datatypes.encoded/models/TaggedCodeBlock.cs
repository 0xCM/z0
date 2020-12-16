//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a labled executable machine-code block
    /// </summary>
    public readonly struct TaggedCodeBlock
    {
        public Name Tag {get;}

        /// <summary>
        /// The encoded content
        /// </summary>
        public CodeBlock Encoded {get;}

        [MethodImpl(Inline)]
        public TaggedCodeBlock(CodeBlock code, string tag)
        {
            Tag = tag;
            Encoded = code;
        }

        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Code;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }

        public ref readonly byte this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public ref readonly byte this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        [MethodImpl(Inline)]
        public bool Equals(TaggedCodeBlock src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => Encoded.Format();


        public override int GetHashCode()
            => Encoded.GetHashCode();

        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);

        [MethodImpl(Inline)]
        internal TaggedCodeBlock(ulong zero)
        {
            Tag = EmptyString;
            Encoded = CodeBlock.Empty;
        }

        [MethodImpl(Inline)]
        public static implicit operator byte[](TaggedCodeBlock src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(TaggedCodeBlock src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(TaggedCodeBlock src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static bool operator==(TaggedCodeBlock a, TaggedCodeBlock b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(TaggedCodeBlock a, TaggedCodeBlock b)
            => !a.Equals(b);

        public static TaggedCodeBlock Empty
            => new TaggedCodeBlock(0);
    }
}