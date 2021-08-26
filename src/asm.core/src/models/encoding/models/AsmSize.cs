//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Blittable(StorageSize)]
    public readonly struct AsmSize
    {
        public const uint StorageSize = PrimalSizes.U8;

        public AsmSizeClass Class {get;}

        public BitWidth Width
        {
            [MethodImpl(Inline)]
            get => Pow2.pow((byte)Class) << 3;
        }

        [MethodImpl(Inline)]
        public AsmSize(AsmSizeClass kind)
        {
            Class = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSize(AsmSizeClass src)
            => new AsmSize(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSizeClass(AsmSize src)
            => src.Class;
    }
}