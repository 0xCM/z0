//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class tbm_identity : BitMatrixTest<tbm_identity>
    {
        public void bm_identity_ng8x8u_check()
        {
            bm_identity_ng_check<N8,byte>();
        }

        public void bm_identity_ng8x16u_check()
        {
            bm_identity_ng_check<N8,short>();
        }

        public void bm_identity_ng16x8u_check()
        {
            bm_identity_ng_check<N16,byte>();
        }

        public void bm_identity_ng18x8u_check()
        {
            bm_identity_ng_check<N18,byte>();
        }

        public void bm_identity_ng19x8u_check()
        {
            bm_identity_ng_check<N18,byte>();
        }

        public void bm_indentity_ng12x16u_check()
        {   
            bm_identity_ng_check<N12,ushort>();
        }

        public void bm_identity_4x8u_check()
        {
            var I = BitMatrix4.Identity;

            for(var i=0; i<4; i++)
            for(var j=0; j<4; j++)
            {
                if(i == j)
                    Claim.eq(Bit.On, I[i,j]);
                else
                    Claim.eq(Bit.Off, I[i,j]);
            }                
        }

        public void bm_identity_8x8u_check()
        {
            var m = BitMatrix8.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());

            var lhs = BitMatrix8.Identity;
            var rhs = BitMatrix8.Identity;
            var result = lhs & rhs;
            for(var row=0; row< result.RowCount; row++)
            for(var col=0; col< result.ColCount; col++)    
                Claim.eq(result[row,col], rhs[row,col]);

        }

        public void bm_identity_16x16u_check()
        {
            var m = BitMatrix16.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());
        }

        public void bm_identity_32x32u_check()
        {        
            var m = BitMatrix32.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());
        }
    
        public void bm_identity_64x64_check()
        {
            var m = BitMatrix64.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],bit.On);
            Claim.yea(m.Diagonal().AllOnes());

            var lhs = BitMatrix64.Identity;
            var rhs = BitMatrix64.Identity;
            var result = lhs & rhs;
            for(var row=0; row<result.RowCount; row++)
            for(var col=0; col<result.ColCount; col++)    
                Claim.eq(result[row,col], rhs[row,col]);
        }

        public void bm_iszero_check()
        {
            Claim.yea(BitMatrix8.Zero.IsZero());
            Claim.nea(BitMatrix8.Identity.IsZero());
            Claim.nea(Random.BitMatrix(n8).IsZero());

            Claim.yea(BitMatrix16.Zero.IsZero());
            Claim.nea(BitMatrix16.Identity.IsZero());
            Claim.nea(Random.BitMatrix(n16).IsZero());

            Claim.yea(BitMatrix32.Zero.IsZero());
            Claim.nea(BitMatrix32.Identity.IsZero());
            Claim.nea(Random.BitMatrix(n32).IsZero());

            Claim.yea(BitMatrix64.Zero.IsZero());
            Claim.nea(BitMatrix64.Identity.IsZero());
            Claim.nea(Random.BitMatrix(n64).IsZero());
        }

        
        void bm_identity_ng_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
       {
            TypeCaseStart<N>();
            var identity = BitMatrix.identity<N,T>();
            for(var i=0; i< identity.RowCount; i++)
            for(var j=0; j< identity.ColCount; j++)
                Claim.eq(identity[i,j], i==j ? Bit.On : Bit.Off);            
            TypeCaseEnd<N>();
        }

    }

}