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
    public readonly struct AsciSequence : IBytes
    {
        internal readonly BinaryCode Storage;

        public int Length  {get;}

        public AsciSequence(BinaryCode src)
        {
            Storage = src;
            Length = asci.length(src);
        }

        public int Capacity
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public ReadOnlySpan<byte> View
            => Storage.Data;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Storage.IsEmpty;
        }

        public string Format()
        {
            var dst = span(sys.alloc<char>(Storage.Length));
            for(var i=0u; i<Storage.Length; i++)
                seek(dst,i) = (char)Storage[(int)i];
            return sys.@string(dst);
        }
    }
}