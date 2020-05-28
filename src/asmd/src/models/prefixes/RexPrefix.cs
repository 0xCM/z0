//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;        
    using static Memories;
    using static OneBit;
    using static Quartet;

    using B1 = OneBit;

    /// <summary>
    /// A prefix that occurrs at most once and is applicable to instructions 
    /// in 64-bit mode, that facilitates specification of: 
    /// a) gp and sse registers
    /// b) 64-bit operand size
    /// c) extended control registers
    /// </summary>
    public struct RexPrefix
    {       
        B1 b;

        B1 x;

        B1 r;

        B1 w;

        [MethodImpl(Inline)]
        public RexPrefix(bit b, bit x, bit r, bit w)
        {
            this.b = (B1)(byte)b;
            this.x = (B1)(byte)x;
            this.r = (B1)(byte)r;
            this.w = (B1)(byte)w;
        }
        
        [MethodImpl(Inline)]
        public RexPrefix(byte src)
        {
            b = Bits.testbit(src, 0) ? b1 : b0;
            x = Bits.testbit(src, 1) ? b1 : b0;
            r = Bits.testbit(src, 2) ? b1 : b0;
            w = Bits.testbit(src, 3) ? b1 : b0;
        }

        public bit B
        {
            [MethodImpl(Inline)]
            get => (byte)b;

            [MethodImpl(Inline)]
            set => b = (B1)(byte)value;
        }

        public bit X
        {
            [MethodImpl(Inline)]
            get => (byte)x;

            [MethodImpl(Inline)]
            set => x = (B1)(byte)value;
        }

        public bit R
        {
            [MethodImpl(Inline)]
            get => (byte)r;

            [MethodImpl(Inline)]
            set => r = (B1)(byte)value;
        }

        public bit W
        {
            [MethodImpl(Inline)]
            get => (byte)w;

            [MethodImpl(Inline)]
            set => w = (B1)(byte)value;
        }

        [MethodImpl(Inline)]
        byte Encode()
        {
            var rex = math.sll((byte)b0100, 4);
            var bx = math.slor((byte)b, 0, (byte)x, 1);
            var rw = math.slor((byte)r, 2, (byte)w, 3);            
            return math.or(bx,rw,rex);
        }

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => Encode();
        }

        [MethodImpl(Inline)]
        public string Format()
            => BitFormatter.format(Encoded);

        public override string ToString()
            => Format();
    }
}