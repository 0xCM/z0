//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
    using static zfunc;         

    using RF = RexFieldId;   
    using RFW = RexFieldWidth;

    public struct RexPrefix : IFixedNumeric<byte>, INumericFormatProvider<RexPrefix>
    {                    
        byte data;

        public static BitFieldReader<RexPrefix> Reader
            => BitField.specify<RexFieldWidth>().Reader<RexPrefix>();

        [MethodImpl(Inline)]
        public static RexPrefix Define(bit b, bit x, bit r, bit w, RexCode kind)
        {
            var data = (byte)gmath.or(
                gmath.sll(b, RF.B),
                gmath.sll(x, RF.X),
                gmath.sll(r, RF.R),
                gmath.sll(w, RF.W),
                gmath.sll((uint)kind, RF.Code));
            return Define(data);
        }
            
        [MethodImpl(Inline)]
        public static RexPrefix Define(byte src)
            => new RexPrefix(src);

        [MethodImpl(Inline)]
        RexPrefix(byte src)
            => this.data = src;

        public byte Data
        {
            [MethodImpl(Inline)] get => data;
            [MethodImpl(Inline)] set => data = value;
        }

        public bit B
        {            
            [MethodImpl(Inline)] get => gbits.test(data,(byte)RF.B);
            [MethodImpl(Inline)] set => data = gbits.set(data,(byte)RF.B, value);
        }

        public bit X
        {                
            [MethodImpl(Inline)] get => gbits.test(data, (byte)RF.X);
            [MethodImpl(Inline)] set => data = gbits.set(data, (byte)RF.X, value);
        }

        public bit R
        {                
            [MethodImpl(Inline)] get => gbits.test(data, (byte)RF.R);
            [MethodImpl(Inline)] set => data = gbits.set(data, (byte)RF.R, value);
        }

        public bit W
        {                
            [MethodImpl(Inline)] get => gbits.test(data, (byte)RF.W);
            [MethodImpl(Inline)] set => data = gbits.set(data, (byte)RF.W, value);
        }

        public RexCode Code
        {                
            [MethodImpl(Inline)] get => (RexCode)gbits.bitslice(data, 4, (byte)RFW.Code);
            [MethodImpl(Inline)] set => data = gbits.bitcopy((byte)value, 4, (byte)RFW.Code, data);
        }

        public INumericFormatter<RexPrefix> Formatter
        {
             [MethodImpl(Inline)]
             get => RexFormatter.Default;
        }
    }
}