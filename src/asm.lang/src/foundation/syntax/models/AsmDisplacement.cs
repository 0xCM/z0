//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmDisplacement
    {
        /// <summary>
        /// The size of the displacement in bytes
        /// </summary>
        public AsmDisplacementSize Size {get;}

        /// <summary>
        /// The displacement value
        /// </summary>
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public AsmDisplacement(ulong value, AsmDisplacementSize size)
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

        public static AsmDisplacement Empty
            => default;
    }
}