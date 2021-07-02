//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp8 : IDisplacement<Disp8,byte>
    {
        /// <summary>
        /// The base displacement magnitude
        /// </summary>
        public byte Value {get;}

        [MethodImpl(Inline)]
        public Disp8(byte @base)
        {
            Value = @base;
        }

        public byte Width => 8;

        public bool IsNonZero
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

        [MethodImpl(Inline)]
        public static implicit operator Disp(Disp8 src)
            => (src.Value,src.Width);
    }
}