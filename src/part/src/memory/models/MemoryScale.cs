//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public enum ScaleFactor : byte
    {
        None = 0,

        S1 = 1,

        S2 = 2,

        S4 = 4,

        S8 = 8
    }

    public readonly struct MemoryScale : ITextual
    {
        public ScaleFactor Factor {get;}

        [MethodImpl(Inline)]
        public MemoryScale(ScaleFactor kind)
            => Factor = kind;

        [MethodImpl(Inline)]
        public MemoryAddress Apply(MemoryAddress src)
            =>(ulong)Factor * src;

        public static MemoryScale Empty
            => new MemoryScale(0);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Factor == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Factor != 0;
        }

        public bool NonUnital
        {
             [MethodImpl(Inline)]
             get => Factor != ScaleFactor.S1;
        }

        public bool NonZero
        {
            [MethodImpl(Inline)]
            get =>  Factor != 0;
        }

        public byte Value
        {
            [MethodImpl(Inline)]
            get => (byte) Factor;
        }

        public MemoryScale Zero
            => Empty;

        [MethodImpl(Inline)]
        public static implicit operator MemoryScale(int src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryScale(ScaleFactor src)
            => new MemoryScale(src);

        [MethodImpl(Inline)]
        public static implicit operator ScaleFactor(MemoryScale src)
            => src.Factor;

        [MethodImpl(Inline)]
        public static MemoryScale From(int value)
        {
            if(value == 1 || value == 2 || value == 4 || value == 8)
                return new MemoryScale((ScaleFactor)value);
            else
                return new MemoryScale(0);
        }

        public string Format()
            => IsNonEmpty ? ((byte)Factor).ToString() : EmptyString;

        public override string ToString()
            => Format();
    }
}