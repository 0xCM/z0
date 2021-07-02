//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Represents an 8-bit, 16-bit or 32-bit displacement
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack =1)]
    public readonly struct Disp
    {
        public uint Value {get;}

        public byte Width {get;}

        [MethodImpl(Inline)]
        public Disp(uint value, byte width)
        {
            Value = value;
            Width = width;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Value != 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp((uint value, byte width) src)
            => new Disp(src.value,src.width);

        public static Disp Empty => default;
    }
}