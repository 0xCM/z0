//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp32
    {
        public uint Value {get;}

        /// <summary>
        /// The scale applied to the displacement
        /// </summary>
        public AsmScale Scale {get;}

        [MethodImpl(Inline)]
        public Disp32(uint value, AsmScale scale = AsmScale.y1)
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
        public static implicit operator Disp32(uint src)
            => new Disp32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(Disp32 src)
            => src.Value;

        public static Disp32 Empty
        {
            [MethodImpl(Inline)]
            get => new Disp32(0);
        }
    }
}