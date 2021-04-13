//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct LocalOffsetVector
    {
        readonly Index<Address16> Data;

        [MethodImpl(Inline)]
        public LocalOffsetVector(Index<Address16> src)
        {
            Data = src;
        }

        public Span<Address16> Components
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref Address16 this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ushort Length
        {
            [MethodImpl(Inline)]
            get => (ushort)Data.Length;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => memory.recover<Address16,byte>(Components);
        }

        [MethodImpl(Inline)]
        public static implicit operator LocalOffsetVector(Address16[] src)
            => new LocalOffsetVector(src);

        [MethodImpl(Inline)]
        public static implicit operator LocalOffsetVector(Index<Address16> src)
            => new LocalOffsetVector(src.Storage);

    }
}