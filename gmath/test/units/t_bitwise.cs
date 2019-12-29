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

            CheckBinaryPredMatch(binary(math.and, name, z8), GZ.and(z8), z8);
            CheckBinaryPredMatch(binary(math.and, name, z8i), GZ.and(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.and, name, z16), GZ.and(z16),z16);
            CheckBinaryPredMatch(binary(math.and, name,z16i), GZ.and(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.and, name,z32), GZ.and(z32),z32);
            CheckBinaryPredMatch(binary(math.and, name,z32i), GZ.and(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.and, name,z64), GZ.and(z64),z64);
            CheckBinaryPredMatch(binary(math.and, name,z64i), GZ.and(z64i),z64i);

        }

        public void check_nand()
        {
            const string name = "nand";

            CheckBinaryPredMatch(binary(math.nand, name, z8), GZ.nand(z8), z8);
            CheckBinaryPredMatch(binary(math.nand, name, z8i), GZ.nand(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.nand, name, z16), GZ.nand(z16),z16);
            CheckBinaryPredMatch(binary(math.nand, name,z16i), GZ.nand(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.nand, name,z32), GZ.nand(z32),z32);
            CheckBinaryPredMatch(binary(math.nand, name,z32i), GZ.nand(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.nand, name,z64), GZ.nand(z64),z64);
            CheckBinaryPredMatch(binary(math.nand, name,z64i), GZ.nand(z64i),z64i);

        }


        public void check_or()
        {
            const string name = "or";

            CheckBinaryPredMatch(binary(math.or, name, z8), GZ.or(z8), z8);
            CheckBinaryPredMatch(binary(math.or, name, z8i), GZ.or(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.or, name, z16), GZ.or(z16),z16);
            CheckBinaryPredMatch(binary(math.or, name,z16i), GZ.or(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.or, name,z32), GZ.or(z32),z32);
            CheckBinaryPredMatch(binary(math.or, name,z32i), GZ.or(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.or, name,z64), GZ.or(z64),z64);
            CheckBinaryPredMatch(binary(math.or, name,z64i), GZ.or(z64i),z64i);

        }

        public void check_nor()
        {
            const string name = "nor";

            CheckBinaryPredMatch(binary(math.nor, name, z8), GZ.nor(z8), z8);
            CheckBinaryPredMatch(binary(math.nor, name, z8i), GZ.nor(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.nor, name, z16), GZ.nor(z16),z16);
            CheckBinaryPredMatch(binary(math.nor, name,z16i), GZ.nor(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.nor, name,z32), GZ.nor(z32),z32);
            CheckBinaryPredMatch(binary(math.nor, name,z32i), GZ.nor(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.nor, name,z64), GZ.nor(z64),z64);
            CheckBinaryPredMatch(binary(math.nor, name,z64i), GZ.nor(z64i),z64i);

        }

        public void check_xor()
        {
            const string name = "xor";

            CheckBinaryPredMatch(binary(math.xor, name, z8), GZ.xor(z8), z8);
            CheckBinaryPredMatch(binary(math.xor, name, z8i), GZ.xor(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.xor, name, z16), GZ.xor(z16),z16);
            CheckBinaryPredMatch(binary(math.xor, name,z16i), GZ.xor(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.xor, name,z32), GZ.xor(z32),z32);
            CheckBinaryPredMatch(binary(math.xor, name,z32i), GZ.xor(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.xor, name,z64), GZ.xor(z64),z64);
            CheckBinaryPredMatch(binary(math.xor, name,z64i), GZ.xor(z64i),z64i);

        }

        public void check_xnor()
        {
            const string name = "xnor";

            CheckBinaryPredMatch(binary(math.xnor, name, z8), GZ.xnor(z8), z8);
            CheckBinaryPredMatch(binary(math.xnor, name, z8i), GZ.xnor(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.xnor, name, z16), GZ.xnor(z16),z16);
            CheckBinaryPredMatch(binary(math.xnor, name,z16i), GZ.xnor(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.xnor, name,z32), GZ.xnor(z32),z32);
            CheckBinaryPredMatch(binary(math.xnor, name,z32i), GZ.xnor(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.xnor, name,z64), GZ.xnor(z64),z64);
            CheckBinaryPredMatch(binary(math.xnor, name,z64i), GZ.xnor(z64i),z64i);

        }

        public void check_not()
        {
            const string name = "not";

            CheckUnaryMatch(unary(math.not, name, z8), GZ.not(z8), z8);
            CheckUnaryMatch(unary(math.not, name, z8i), GZ.not(z8i), z8i);
            
            CheckUnaryMatch(unary(math.not, name, z16), GZ.not(z16),z16);
            CheckUnaryMatch(unary(math.not, name,z16i), GZ.not(z16i),z16i);
            
            CheckUnaryMatch(unary(math.not, name,z32), GZ.not(z32),z32);
            CheckUnaryMatch(unary(math.not, name,z32i), GZ.not(z32i),z32i);
                        
            CheckUnaryMatch(unary(math.not, name,z64), GZ.not(z64),z64);
            CheckUnaryMatch(unary(math.not, name,z64i), GZ.not(z64i),z64i);

        }


    }
}