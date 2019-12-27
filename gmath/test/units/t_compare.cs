//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static OpDelegate;

    public class t_compare : t_gmath<t_compare>
    {     
        public void eq()
        {
            const string name = "eq";

            check_binarypred_match(predicate(math.eq, name, z8), KOps.eq(z8), z8);
            check_binarypred_match(predicate(math.eq, name, z8i), KOps.eq(z8i), z8i);
            
            check_binarypred_match(predicate(math.eq, name, z16), KOps.eq(z16),z16);
            check_binarypred_match(predicate(math.eq, name,z16i), KOps.eq(z16i),z16i);
            
            check_binarypred_match(predicate(math.eq, name,z32), KOps.eq(z32),z32);
            check_binarypred_match(predicate(math.eq, name,z32i), KOps.eq(z32i),z32i);
                        
            check_binarypred_match(predicate(math.eq, name,z64), KOps.eq(z64),z64);
            check_binarypred_match(predicate(math.eq, name,z64i), KOps.eq(z64i),z64i);

            check_binarypred_match(predicate(fmath.eq, name, z32f), KOps.eq(z32f),z32f);
            check_binarypred_match(predicate(fmath.eq, name,z64f), KOps.eq(z64f),z64f);

        }

        public void neq()
        {
            const string name = "neq";

            check_binarypred_match(predicate(math.neq, name, z8), KOps.neq(z8), z8);
            check_binarypred_match(predicate(math.neq, name, z8i), KOps.neq(z8i), z8i);
            
            check_binarypred_match(predicate(math.neq, name, z16), KOps.neq(z16),z16);
            check_binarypred_match(predicate(math.neq, name,z16i), KOps.neq(z16i),z16i);
            
            check_binarypred_match(predicate(math.neq, name,z32), KOps.neq(z32),z32);
            check_binarypred_match(predicate(math.neq, name,z32i), KOps.neq(z32i),z32i);
                        
            check_binarypred_match(predicate(math.neq, name,z64), KOps.neq(z64),z64);
            check_binarypred_match(predicate(math.neq, name,z64i), KOps.neq(z64i),z64i);

            check_binarypred_match(predicate(fmath.neq, name, z32f), KOps.neq(z32f),z32f);
            check_binarypred_match(predicate(fmath.neq, name,z64f), KOps.neq(z64f),z64f);

        }

        public void gt()
        {
            const string name = "gt";

            check_binarypred_match(predicate(math.gt, name, z8), KOps.gt(z8), z8);
            check_binarypred_match(predicate(math.gt, name, z8i), KOps.gt(z8i), z8i);
            
            check_binarypred_match(predicate(math.gt, name, z16), KOps.gt(z16),z16);
            check_binarypred_match(predicate(math.gt, name,z16i), KOps.gt(z16i),z16i);
            
            check_binarypred_match(predicate(math.gt, name,z32), KOps.gt(z32),z32);
            check_binarypred_match(predicate(math.gt, name,z32i), KOps.gt(z32i),z32i);
                        
            check_binarypred_match(predicate(math.gt, name,z64), KOps.gt(z64),z64);
            check_binarypred_match(predicate(math.gt, name,z64i), KOps.gt(z64i),z64i);

            check_binarypred_match(predicate(fmath.gt, name, z32f), KOps.gt(z32f),z32f);
            check_binarypred_match(predicate(fmath.gt, name,z64f), KOps.gt(z64f),z64f);

        }

        public void gteq()
        {
            const string name = "gteq";

            check_binarypred_match(predicate(math.gteq, name, z8), KOps.gteq(z8), z8);
            check_binarypred_match(predicate(math.gteq, name, z8i), KOps.gteq(z8i), z8i);
            
            check_binarypred_match(predicate(math.gteq, name, z16), KOps.gteq(z16),z16);
            check_binarypred_match(predicate(math.gteq, name,z16i), KOps.gteq(z16i),z16i);
            
            check_binarypred_match(predicate(math.gteq, name,z32), KOps.gteq(z32),z32);
            check_binarypred_match(predicate(math.gteq, name,z32i), KOps.gteq(z32i),z32i);
                        
            check_binarypred_match(predicate(math.gteq, name,z64), KOps.gteq(z64),z64);
            check_binarypred_match(predicate(math.gteq, name,z64i), KOps.gteq(z64i),z64i);

            check_binarypred_match(predicate(fmath.gteq, name, z32f), KOps.gteq(z32f),z32f);
            check_binarypred_match(predicate(fmath.gteq, name,z64f), KOps.gteq(z64f),z64f);
        }

        public void lt()
        {
            const string name = "lt";

            check_binarypred_match(predicate(math.lt, name, z8), KOps.lt(z8), z8);
            check_binarypred_match(predicate(math.lt, name, z8i), KOps.lt(z8i), z8i);
            
            check_binarypred_match(predicate(math.lt, name, z16), KOps.lt(z16),z16);
            check_binarypred_match(predicate(math.lt, name,z16i), KOps.lt(z16i),z16i);
            
            check_binarypred_match(predicate(math.lt, name,z32), KOps.lt(z32),z32);
            check_binarypred_match(predicate(math.lt, name,z32i), KOps.lt(z32i),z32i);
                        
            check_binarypred_match(predicate(math.lt, name,z64), KOps.lt(z64),z64);
            check_binarypred_match(predicate(math.lt, name,z64i), KOps.lt(z64i),z64i);

            check_binarypred_match(predicate(fmath.lt, name, z32f), KOps.lt(z32f),z32f);
            check_binarypred_match(predicate(fmath.lt, name,z64f), KOps.lt(z64f),z64f);

        }

        public void lteq()
        {
            const string name = "lteq";

            check_binarypred_match(predicate(math.lteq, name, z8), KOps.lteq(z8), z8);
            check_binarypred_match(predicate(math.lteq, name, z8i), KOps.lteq(z8i), z8i);
            
            check_binarypred_match(predicate(math.lteq, name, z16), KOps.lteq(z16),z16);
            check_binarypred_match(predicate(math.lteq, name,z16i), KOps.lteq(z16i),z16i);
            
            check_binarypred_match(predicate(math.lteq, name,z32), KOps.lteq(z32),z32);
            check_binarypred_match(predicate(math.lteq, name,z32i), KOps.lteq(z32i),z32i);
                        
            check_binarypred_match(predicate(math.lteq, name,z64), KOps.lteq(z64),z64);
            check_binarypred_match(predicate(math.lteq, name,z64i), KOps.lteq(z64i),z64i);

            check_binarypred_match(predicate(fmath.lteq, name, z32f), KOps.lteq(z32f),z32f);
            check_binarypred_match(predicate(fmath.lteq, name,z64f), KOps.lteq(z64f),z64f);

        }

    }
}