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

    /// <summary>
    /// Covers a sequence of asci-encoded bytes
    /// </summary>
    public readonly struct AsciSequence : IAsciSeq
    {
        readonly BinaryCode Data;

        public int Length  {get;}

        public AsciSequence(BinaryCode src)
        {
            Data = src;
            Length = Asci.length(src);
        }

        public int Capacity
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ReadOnlySpan<AsciCharCode> Codes
        {
            [MethodImpl(Inline)]
            get => memory.recover<byte,AsciCharCode>(View);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public TextBlock Text
        {
            [MethodImpl(Inline)]
            get => Format();
        }

        public string Format()
        {
            var len = Length;
            var dst = span(sys.alloc<char>(len));
            var src = Data.View;
            for(var i=0u; i<len; i++)
                seek(dst, i) = (char)skip(src,i);
            return sys.@string(dst);
        }

        public override string ToString()
            => Format();
    }
}