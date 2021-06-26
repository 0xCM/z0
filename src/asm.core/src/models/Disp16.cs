//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp16
    {
        /// <summary>
        /// The base displacement magnitude
        /// </summary>
        public ushort Value {get;}

        /// <summary>
        /// The scale applied to the displacement
        /// </summary>
        public AsmScale Scale {get;}

        [MethodImpl(Inline)]
        public Disp16(ushort value, AsmScale scale = AsmScale.y1)
        {
            Value = value;
            Scale = scale;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp16(ushort src)
            => new Disp16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(Disp16 src)
            => src.Value;
    }
}