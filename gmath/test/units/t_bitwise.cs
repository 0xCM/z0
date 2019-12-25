//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_bitwise : t_gmath<t_bitwise>
    {

        public void check_and()
        {
            const string name = "and";

            check_binary_match(ZOps.binary(math.and, name, z8), KOps.and(z8), z8);
            check_binary_match(ZOps.binary(math.and, name, z8i), KOps.and(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.and, name, z16), KOps.and(z16),z16);
            check_binary_match(ZOps.binary(math.and, name,z16i), KOps.and(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.and, name,z32), KOps.and(z32),z32);
            check_binary_match(ZOps.binary(math.and, name,z32i), KOps.and(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.and, name,z64), KOps.and(z64),z64);
            check_binary_match(ZOps.binary(math.and, name,z64i), KOps.and(z64i),z64i);

        }

        public void check_nand()
        {
            const string name = "nand";

            check_binary_match(ZOps.binary(math.nand, name, z8), KOps.nand(z8), z8);
            check_binary_match(ZOps.binary(math.nand, name, z8i), KOps.nand(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.nand, name, z16), KOps.nand(z16),z16);
            check_binary_match(ZOps.binary(math.nand, name,z16i), KOps.nand(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.nand, name,z32), KOps.nand(z32),z32);
            check_binary_match(ZOps.binary(math.nand, name,z32i), KOps.nand(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.nand, name,z64), KOps.nand(z64),z64);
            check_binary_match(ZOps.binary(math.nand, name,z64i), KOps.nand(z64i),z64i);

        }


        public void check_or()
        {
            const string name = "or";

            check_binary_match(ZOps.binary(math.or, name, z8), KOps.or(z8), z8);
            check_binary_match(ZOps.binary(math.or, name, z8i), KOps.or(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.or, name, z16), KOps.or(z16),z16);
            check_binary_match(ZOps.binary(math.or, name,z16i), KOps.or(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.or, name,z32), KOps.or(z32),z32);
            check_binary_match(ZOps.binary(math.or, name,z32i), KOps.or(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.or, name,z64), KOps.or(z64),z64);
            check_binary_match(ZOps.binary(math.or, name,z64i), KOps.or(z64i),z64i);

        }

        public void check_nor()
        {
            const string name = "nor";

            check_binary_match(ZOps.binary(math.nor, name, z8), KOps.nor(z8), z8);
            check_binary_match(ZOps.binary(math.nor, name, z8i), KOps.nor(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.nor, name, z16), KOps.nor(z16),z16);
            check_binary_match(ZOps.binary(math.nor, name,z16i), KOps.nor(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.nor, name,z32), KOps.nor(z32),z32);
            check_binary_match(ZOps.binary(math.nor, name,z32i), KOps.nor(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.nor, name,z64), KOps.nor(z64),z64);
            check_binary_match(ZOps.binary(math.nor, name,z64i), KOps.nor(z64i),z64i);

        }

        public void check_xor()
        {
            const string name = "xor";

            check_binary_match(ZOps.binary(math.xor, name, z8), KOps.xor(z8), z8);
            check_binary_match(ZOps.binary(math.xor, name, z8i), KOps.xor(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.xor, name, z16), KOps.xor(z16),z16);
            check_binary_match(ZOps.binary(math.xor, name,z16i), KOps.xor(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.xor, name,z32), KOps.xor(z32),z32);
            check_binary_match(ZOps.binary(math.xor, name,z32i), KOps.xor(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.xor, name,z64), KOps.xor(z64),z64);
            check_binary_match(ZOps.binary(math.xor, name,z64i), KOps.xor(z64i),z64i);

        }

        public void check_xnor()
        {
            const string name = "xnor";

            check_binary_match(ZOps.binary(math.xnor, name, z8), KOps.xnor(z8), z8);
            check_binary_match(ZOps.binary(math.xnor, name, z8i), KOps.xnor(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.xnor, name, z16), KOps.xnor(z16),z16);
            check_binary_match(ZOps.binary(math.xnor, name,z16i), KOps.xnor(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.xnor, name,z32), KOps.xnor(z32),z32);
            check_binary_match(ZOps.binary(math.xnor, name,z32i), KOps.xnor(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.xnor, name,z64), KOps.xnor(z64),z64);
            check_binary_match(ZOps.binary(math.xnor, name,z64i), KOps.xnor(z64i),z64i);

        }

        public void check_not()
        {
            const string name = "not";

            check_unary_match(ZOps.unary(math.not, name, z8), KOps.not(z8), z8);
            check_unary_match(ZOps.unary(math.not, name, z8i), KOps.not(z8i), z8i);
            
            check_unary_match(ZOps.unary(math.not, name, z16), KOps.not(z16),z16);
            check_unary_match(ZOps.unary(math.not, name,z16i), KOps.not(z16i),z16i);
            
            check_unary_match(ZOps.unary(math.not, name,z32), KOps.not(z32),z32);
            check_unary_match(ZOps.unary(math.not, name,z32i), KOps.not(z32i),z32i);
                        
            check_unary_match(ZOps.unary(math.not, name,z64), KOps.not(z64),z64);
            check_unary_match(ZOps.unary(math.not, name,z64i), KOps.not(z64i),z64i);

        }


    }
}