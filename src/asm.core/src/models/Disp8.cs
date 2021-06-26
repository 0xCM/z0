//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp8
    {
        /// <summary>
        /// The base displacement magnitude
        /// </summary>
        public byte Value {get;}

        /// <summary>
        /// The scale applied to the displacement
        /// </summary>
        public AsmScale Scale {get;}

        [MethodImpl(Inline)]
        public Disp8(byte value, AsmScale scale = AsmScale.y1)
        {
            Scale = scale;
            Value = value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp8(byte src)
            => new Disp8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(Disp8 src)
            => src.Value;
    }
}