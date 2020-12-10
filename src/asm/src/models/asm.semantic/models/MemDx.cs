//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemDx
    {
        /// <summary>
        /// The size of the displacement in bytes
        /// </summary>
        public MemDxSize Size {get;}

        /// <summary>
        /// The displacement value
        /// </summary>
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public MemDx(ulong value, MemDxSize size)
        {
            Value = value;
            Size = size;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value == 0 && Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Value != 0 && Size != 0;
        }

        public bool NonZero
        {
            [MethodImpl(Inline)]
            get => Value != 0;
        }

        HexFormatOptions HexSpec
            => HexFormatSpecs.options(zpad:false, specifier:false);

        public string Format()
            => (Size switch{
                MemDxSize.y1 => ((byte)Value).FormatHex(HexSpec),
                MemDxSize.y2 => ((ushort)Value).FormatHex(HexSpec),
                MemDxSize.y4 => ((uint)Value).FormatHex(HexSpec),
                _ => (Value).FormatHex(HexSpec),
            }) + "dx";

        public override string ToString()
            => Format();

        public static MemDx Empty
            => default;
    }
}