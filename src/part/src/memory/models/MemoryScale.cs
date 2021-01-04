//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Isomorphic(typeof(MemoryScaleFactor))]
    public readonly struct MemoryScale : ITextual
    {
        public MemoryScaleFactor Factor {get;}

        [MethodImpl(Inline)]
        public MemoryScale(MemoryScaleFactor kind)
            => Factor = kind;

        [MethodImpl(Inline)]
        public MemoryAddress Apply(MemoryAddress src)
            =>(ulong)Factor * src;

        public static MemoryScale Empty
            => new MemoryScale(MemoryScaleFactor.None);

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
             get => Factor != MemoryScaleFactor.S1;
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
        public static implicit operator MemoryScale(MemoryScaleFactor src)
            => new MemoryScale(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryScaleFactor(MemoryScale src)
            => src.Factor;

        [MethodImpl(Inline)]
        public static MemoryScale From(int value)
        {
            if(value == 1 || value == 2 || value == 4 || value == 8)
                return new MemoryScale((MemoryScaleFactor)value);
            else
                return new MemoryScale(MemoryScaleFactor.None);
        }

        public string Format()
            => IsNonEmpty ? ((byte)Factor).ToString() : EmptyString;

        public override string ToString()
            => Format();
    }
}