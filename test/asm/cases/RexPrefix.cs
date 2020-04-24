//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;         

    using RFI = RexFieldIndex;   
    using RFW = RexFieldWidth;

    public struct RexPrefix : IScalarField<byte>, IFormattable<RexPrefix>
    {                    
        public byte Content;

        public static RexPrefix Empty => Define(0,0,0,0,0);

        [MethodImpl(Inline)]
        public static RexPrefix Define(bit b, bit x, bit r, bit w, RexCode kind)
        {
            var data = (byte)gmath.or(
                gmath.sll(b, RFI.B),
                gmath.sll(x, RFI.X),
                gmath.sll(r, RFI.R),
                gmath.sll(w, RFI.W),
                gmath.sll((uint)kind, RFI.Code));
            return Define(data);
        }
            
        [MethodImpl(Inline)]
        public static RexPrefix Define(byte src)
            => new RexPrefix(src);
    
        [MethodImpl(Inline)]
        RexPrefix(byte src)
            => this.Content = src;

        public byte Scalar
        {
            [MethodImpl(Inline)] get => Content;
            [MethodImpl(Inline)] set => Content = value;
        }

        public bit B
        {            
            [MethodImpl(Inline)] get => gbits.testbit(Content,(byte)RFI.B);
            [MethodImpl(Inline)] set => Content = gbits.setbit(Content,(byte)RFI.B, value);
        }

        public bit X
        {                
            [MethodImpl(Inline)] get => gbits.testbit(Content, (byte)RFI.X);
            [MethodImpl(Inline)] set => Content = gbits.setbit(Content, (byte)RFI.X, value);
        }

        public bit R
        {                
            [MethodImpl(Inline)] get => gbits.testbit(Content, (byte)RFI.R);
            [MethodImpl(Inline)] set => Content = gbits.setbit(Content, (byte)RFI.R, value);
        }

        public bit W
        {                
            [MethodImpl(Inline)] get => gbits.testbit(Content, (byte)RFI.W);
            [MethodImpl(Inline)] set => Content = gbits.setbit(Content, (byte)RFI.W, value);
        }

        public RexCode Code
        {                
            [MethodImpl(Inline)] get => (RexCode)gbits.slice(Content, 4, (byte)RFW.Code);
            [MethodImpl(Inline)] set => Content = gbits.bitcopy((byte)value, 4, (byte)RFW.Code, Content);
        }

        public string Format()
            => RexFormatter.Default.Format(this);
    }
}