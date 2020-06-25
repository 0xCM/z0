//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Label(TypeLabels.Dx)]
    public readonly struct AsmMemDx : INullity, INullary<AsmMemDx>, ITextual
    {        
        /// <summary>
        /// The size of the displacement in bytes
        /// </summary>
        public DataSize Size {get;}

        /// <summary>
        /// The displacement value
        /// </summary>
        public ulong Value {get;}

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

        public AsmMemDx Zero => Empty;

        [MethodImpl(Inline)]
        public static implicit operator AsmMemDx((ulong value, int size) src)
            => From(src.value, src.size);

        [MethodImpl(Inline)]
        public static AsmMemDx Create(ulong value, DataSize size)
            => new AsmMemDx(value, size);
        
        [MethodImpl(Inline)]
        public static AsmMemDx From(ulong value, int size)
            => new AsmMemDx(value,  Enums.definedOrElse((DataSize)size, DataSize.None));

        [MethodImpl(Inline)]
        public AsmMemDx(ulong value, DataSize size)
        {
            this.Value = value;
            this.Size = size;
            HexSpec = HexFormatConfig.Define(zpad:false, specifier:false);
        }

        readonly HexFormatConfig HexSpec; 

        public string Format()
            => (Size switch{
                DataSize.Size1 => ((byte)Value).FormatHex(HexSpec),
                DataSize.Size2 => ((ushort)Value).FormatHex(HexSpec),
                DataSize.Size4 => ((uint)Value).FormatHex(HexSpec),
                _ => (Value).FormatHex(HexSpec),
            }) + "dx";

        public override string ToString()
            => Format();

        public static AsmMemDx Empty 
            => default;

    }
}