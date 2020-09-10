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

    public readonly ref struct EmissionBuffer
    {

        public const uint DefaultSize = Max16u;

        readonly Span<byte> Buffer;


        [MethodImpl(Inline)]
        public EmissionBuffer(byte[] src)
            => Buffer = src;

        [MethodImpl(Inline)]
        public EmissionBuffer(Span<byte> src)
            => Buffer = src;

        public uint Size
        {
            [MethodImpl(Inline)]
            get => (uint)Buffer.Length;
        }

        public ref byte this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Buffer,index);
        }
    }
}