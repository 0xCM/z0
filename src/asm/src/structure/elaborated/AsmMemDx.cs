//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmMemDx
    {
        /// <summary>
        /// The size of the displacement in bytes
        /// </summary>
        public readonly NumericSize Size;

        /// <summary>
        /// The displacement value
        /// </summary>
        public readonly ulong Value;

        [MethodImpl(Inline)]
        public static implicit operator AsmMemDx((ulong value, int size) src)
            => From(src.value, src.size);

        [MethodImpl(Inline)]
        public static AsmMemDx From(ulong value, int size)
            => new AsmMemDx(value, 
            Enums.definedOrElse((NumericSize)size,NumericSize.None)
            );

        [MethodImpl(Inline)]
        public AsmMemDx(ulong value, NumericSize size)
        {
            this.Value = value;
            this.Size = size;
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
    }
}