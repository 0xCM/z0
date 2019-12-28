//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
    using static OpDelegate;

    public class t_bitwise : t_gmath<t_bitwise>
    {

        public void check_and()
        {
            const string name = "and";

            CheckBinaryPredMatch(binary(math.and, name, z8), KOps.and(z8), z8);
            CheckBinaryPredMatch(binary(math.and, name, z8i), KOps.and(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.and, name, z16), KOps.and(z16),z16);
            CheckBinaryPredMatch(binary(math.and, name,z16i), KOps.and(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.and, name,z32), KOps.and(z32),z32);
            CheckBinaryPredMatch(binary(math.and, name,z32i), KOps.and(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.and, name,z64), KOps.and(z64),z64);
            CheckBinaryPredMatch(binary(math.and, name,z64i), KOps.and(z64i),z64i);

        }

        public void check_nand()
        {
            const string name = "nand";

            CheckBinaryPredMatch(binary(math.nand, name, z8), KOps.nand(z8), z8);
            CheckBinaryPredMatch(binary(math.nand, name, z8i), KOps.nand(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.nand, name, z16), KOps.nand(z16),z16);
            CheckBinaryPredMatch(binary(math.nand, name,z16i), KOps.nand(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.nand, name,z32), KOps.nand(z32),z32);
            CheckBinaryPredMatch(binary(math.nand, name,z32i), KOps.nand(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.nand, name,z64), KOps.nand(z64),z64);
            CheckBinaryPredMatch(binary(math.nand, name,z64i), KOps.nand(z64i),z64i);

        }


        public void check_or()
        {
            const string name = "or";

            CheckBinaryPredMatch(binary(math.or, name, z8), KOps.or(z8), z8);
            CheckBinaryPredMatch(binary(math.or, name, z8i), KOps.or(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.or, name, z16), KOps.or(z16),z16);
            CheckBinaryPredMatch(binary(math.or, name,z16i), KOps.or(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.or, name,z32), KOps.or(z32),z32);
            CheckBinaryPredMatch(binary(math.or, name,z32i), KOps.or(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.or, name,z64), KOps.or(z64),z64);
            CheckBinaryPredMatch(binary(math.or, name,z64i), KOps.or(z64i),z64i);

        }

        public void check_nor()
        {
            const string name = "nor";

            CheckBinaryPredMatch(binary(math.nor, name, z8), KOps.nor(z8), z8);
            CheckBinaryPredMatch(binary(math.nor, name, z8i), KOps.nor(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.nor, name, z16), KOps.nor(z16),z16);
            CheckBinaryPredMatch(binary(math.nor, name,z16i), KOps.nor(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.nor, name,z32), KOps.nor(z32),z32);
            CheckBinaryPredMatch(binary(math.nor, name,z32i), KOps.nor(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.nor, name,z64), KOps.nor(z64),z64);
            CheckBinaryPredMatch(binary(math.nor, name,z64i), KOps.nor(z64i),z64i);

        }

        public void check_xor()
        {
            const string name = "xor";

            CheckBinaryPredMatch(binary(math.xor, name, z8), KOps.xor(z8), z8);
            CheckBinaryPredMatch(binary(math.xor, name, z8i), KOps.xor(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.xor, name, z16), KOps.xor(z16),z16);
            CheckBinaryPredMatch(binary(math.xor, name,z16i), KOps.xor(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.xor, name,z32), KOps.xor(z32),z32);
            CheckBinaryPredMatch(binary(math.xor, name,z32i), KOps.xor(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.xor, name,z64), KOps.xor(z64),z64);
            CheckBinaryPredMatch(binary(math.xor, name,z64i), KOps.xor(z64i),z64i);

        }

        public void check_xnor()
        {
            const string name = "xnor";

            CheckBinaryPredMatch(binary(math.xnor, name, z8), KOps.xnor(z8), z8);
            CheckBinaryPredMatch(binary(math.xnor, name, z8i), KOps.xnor(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.xnor, name, z16), KOps.xnor(z16),z16);
            CheckBinaryPredMatch(binary(math.xnor, name,z16i), KOps.xnor(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.xnor, name,z32), KOps.xnor(z32),z32);
            CheckBinaryPredMatch(binary(math.xnor, name,z32i), KOps.xnor(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.xnor, name,z64), KOps.xnor(z64),z64);
            CheckBinaryPredMatch(binary(math.xnor, name,z64i), KOps.xnor(z64i),z64i);

        }

        public void check_not()
        {
            const string name = "not";

            CheckUnaryMatch(unary(math.not, name, z8), KOps.not(z8), z8);
            CheckUnaryMatch(unary(math.not, name, z8i), KOps.not(z8i), z8i);
            
            CheckUnaryMatch(unary(math.not, name, z16), KOps.not(z16),z16);
            CheckUnaryMatch(unary(math.not, name,z16i), KOps.not(z16i),z16i);
            
            CheckUnaryMatch(unary(math.not, name,z32), KOps.not(z32),z32);
            CheckUnaryMatch(unary(math.not, name,z32i), KOps.not(z32i),z32i);
                        
            CheckUnaryMatch(unary(math.not, name,z64), KOps.not(z64),z64);
            CheckUnaryMatch(unary(math.not, name,z64i), KOps.not(z64i),z64i);

        }


    }
}