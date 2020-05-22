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
    using RF = RexFieldIndex;   


    public struct RexPrefix : IScalarField<byte>
    {                    
        public static ref RexPrefix BitCopy(in RexPrefix src, ref RexPrefix dst)        
        {
            var bf = RexPrefix.BitField;            
            bf.Write(RFI.B, src, ref dst);
            bf.Write(RFI.X, src, ref dst);
            bf.Write(RFI.R, src, ref dst);
            bf.Write(RFI.W, src, ref dst);
            bf.Write(RFI.Code, src, ref dst);
            return ref dst;
        }

        byte Data;

        /// <summary>
        /// Creates a bitfield over the rex prefix data structure and using the index/width
        /// enumerations to specified the bit layout
        /// </summary>
        public static BitField<RexPrefix,RexFieldIndex,byte> BitField
        {
            [MethodImpl(Inline)]
            get => BitFields.create<RexPrefix,RexFieldIndex,byte,RexFieldWidth>();
        }

        public byte Scalar  
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public ref readonly byte Update(in byte src)
        {
            Data = src;
            return ref src;
        }

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
            => Data = src;

        public bit B
        {            
            [MethodImpl(Inline)] get => gbits.testbit(Scalar,(byte)RFI.B);
            [MethodImpl(Inline)] set => Update(gbits.setbit(Scalar,(byte)RFI.B, value));
        }

        public bit X
        {                
            [MethodImpl(Inline)] get => gbits.testbit(Scalar, (byte)RFI.X);
            [MethodImpl(Inline)] set => Update(gbits.setbit(Scalar, (byte)RFI.X, value));
        }

        public bit R
        {                
            [MethodImpl(Inline)] get => gbits.testbit(Scalar, (byte)RFI.R);
            [MethodImpl(Inline)] set => Update(gbits.setbit(Scalar, (byte)RFI.R, value));
        }

        public bit W
        {                
            [MethodImpl(Inline)] get => gbits.testbit(Scalar, (byte)RFI.W);
            [MethodImpl(Inline)] set => Update(gbits.setbit(Scalar, (byte)RFI.W, value));
        }

        public RexCode Code
        {                
            [MethodImpl(Inline)] get => (RexCode)gbits.slice(Scalar, 4, (byte)RFW.Code);
            [MethodImpl(Inline)] set => Update(gbits.copy((byte)value, 4, (byte)RFW.Code, Scalar));
        }

        public string Render()
            => $"{RF.Code}:{Code} | {RF.W}:{W} | {RF.R}:{R} | {RF.X}:{X} | {RF.B}:{B}";
    }
}