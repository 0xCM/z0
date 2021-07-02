//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp16 : IDisplacement<Disp16,ushort>
    {
        /// <summary>
        /// The base displacement magnitude
        /// </summary>
        public ushort Value {get;}

        [MethodImpl(Inline)]
        public Disp16(ushort value)
        {
            Value = value;
        }

        public byte Width => 16;

        public bool IsNonZero
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

        [MethodImpl(Inline)]
        public static implicit operator Disp(Disp16 src)
            => (src.Value,src.Width);
    }
}