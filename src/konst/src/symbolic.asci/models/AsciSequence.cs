//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

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

        public string Format()
        {
            var dst = span(sys.alloc<char>(Data.Length));
            for(var i=0u; i<Data.Length; i++)
                seek(dst,i) = (char)Data[(int)i];
            return sys.@string(dst);
        }
    }
}