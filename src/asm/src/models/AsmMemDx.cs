//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmMemDx : INullaryKnown, INullary<AsmMemDx>
    {
        public static AsmMemDx Empty => new AsmMemDx(0, NumericSize.None);
        
        /// <summary>
        /// The size of the displacement in bytes
        /// </summary>
        public NumericSize Size {get;}

        /// <summary>
        /// The displacement value
        /// </summary>
        public ulong Value {get;}

        public bool IsEmpty { [MethodImpl(Inline)] get => Value == 0 && Size == 0; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Value != 0 && Size != 0; }

        public bool NonZero => Value != 0;

        public AsmMemDx Zero => Empty;

        [MethodImpl(Inline)]
        public static implicit operator AsmMemDx((ulong value, int size) src)
            => From(src.value, src.size);

        [MethodImpl(Inline)]
        public static AsmMemDx From(ulong value, int size)
            => new AsmMemDx(value,  Enums.definedOrElse((NumericSize)size, NumericSize.None));

        [MethodImpl(Inline)]
        public AsmMemDx(ulong value, NumericSize size)
        {
            this.Value = value;
            this.Size = size;
            HexSpec = HexFormatConfig.Define(zpad:false, specifier:false);
        }

        readonly HexFormatConfig HexSpec; 

        public string Render()
            => (Size switch{
                NumericSize.SZ1 => ((byte)Value).FormatHex(HexSpec),
                NumericSize.SZ2 => ((ushort)Value).FormatHex(HexSpec),
                NumericSize.SZ4 => ((uint)Value).FormatHex(HexSpec),
                _ => (Value).FormatHex(HexSpec),
            }) + "dx";
    }
}