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

            CheckBinaryPredMatch(predicate(math.eq, name, z8), GZ.eq(z8), z8);
            CheckBinaryPredMatch(predicate(math.eq, name, z8i), GZ.eq(z8i), z8i);
            
            CheckBinaryPredMatch(predicate(math.eq, name, z16), GZ.eq(z16),z16);
            CheckBinaryPredMatch(predicate(math.eq, name,z16i), GZ.eq(z16i),z16i);
            
            CheckBinaryPredMatch(predicate(math.eq, name,z32), GZ.eq(z32),z32);
            CheckBinaryPredMatch(predicate(math.eq, name,z32i), GZ.eq(z32i),z32i);
                        
            CheckBinaryPredMatch(predicate(math.eq, name,z64), GZ.eq(z64),z64);
            CheckBinaryPredMatch(predicate(math.eq, name,z64i), GZ.eq(z64i),z64i);

            CheckBinaryPredMatch(predicate(fmath.eq, name, z32f), GZ.eq(z32f),z32f);
            CheckBinaryPredMatch(predicate(fmath.eq, name,z64f), GZ.eq(z64f),z64f);

        }

        public void neq()
        {
            const string name = "neq";

            CheckBinaryPredMatch(predicate(math.neq, name, z8), GZ.neq(z8), z8);
            CheckBinaryPredMatch(predicate(math.neq, name, z8i), GZ.neq(z8i), z8i);
            
            CheckBinaryPredMatch(predicate(math.neq, name, z16), GZ.neq(z16),z16);
            CheckBinaryPredMatch(predicate(math.neq, name,z16i), GZ.neq(z16i),z16i);
            
            CheckBinaryPredMatch(predicate(math.neq, name,z32), GZ.neq(z32),z32);
            CheckBinaryPredMatch(predicate(math.neq, name,z32i), GZ.neq(z32i),z32i);
                        
            CheckBinaryPredMatch(predicate(math.neq, name,z64), GZ.neq(z64),z64);
            CheckBinaryPredMatch(predicate(math.neq, name,z64i), GZ.neq(z64i),z64i);

            CheckBinaryPredMatch(predicate(fmath.neq, name, z32f), GZ.neq(z32f),z32f);
            CheckBinaryPredMatch(predicate(fmath.neq, name,z64f), GZ.neq(z64f),z64f);

        }

        public void gt()
        {
            const string name = "gt";

            CheckBinaryPredMatch(predicate(math.gt, name, z8), GZ.gt(z8), z8);
            CheckBinaryPredMatch(predicate(math.gt, name, z8i), GZ.gt(z8i), z8i);
            
            CheckBinaryPredMatch(predicate(math.gt, name, z16), GZ.gt(z16),z16);
            CheckBinaryPredMatch(predicate(math.gt, name,z16i), GZ.gt(z16i),z16i);
            
            CheckBinaryPredMatch(predicate(math.gt, name,z32), GZ.gt(z32),z32);
            CheckBinaryPredMatch(predicate(math.gt, name,z32i), GZ.gt(z32i),z32i);
                        
            CheckBinaryPredMatch(predicate(math.gt, name,z64), GZ.gt(z64),z64);
            CheckBinaryPredMatch(predicate(math.gt, name,z64i), GZ.gt(z64i),z64i);

            CheckBinaryPredMatch(predicate(fmath.gt, name, z32f), GZ.gt(z32f),z32f);
            CheckBinaryPredMatch(predicate(fmath.gt, name,z64f), GZ.gt(z64f),z64f);

        }

        public void gteq()
        {
            const string name = "gteq";

            CheckBinaryPredMatch(predicate(math.gteq, name, z8), GZ.gteq(z8), z8);
            CheckBinaryPredMatch(predicate(math.gteq, name, z8i), GZ.gteq(z8i), z8i);
            
            CheckBinaryPredMatch(predicate(math.gteq, name, z16), GZ.gteq(z16),z16);
            CheckBinaryPredMatch(predicate(math.gteq, name,z16i), GZ.gteq(z16i),z16i);
            
            CheckBinaryPredMatch(predicate(math.gteq, name,z32), GZ.gteq(z32),z32);
            CheckBinaryPredMatch(predicate(math.gteq, name,z32i), GZ.gteq(z32i),z32i);
                        
            CheckBinaryPredMatch(predicate(math.gteq, name,z64), GZ.gteq(z64),z64);
            CheckBinaryPredMatch(predicate(math.gteq, name,z64i), GZ.gteq(z64i),z64i);

            CheckBinaryPredMatch(predicate(fmath.gteq, name, z32f), GZ.gteq(z32f),z32f);
            CheckBinaryPredMatch(predicate(fmath.gteq, name,z64f), GZ.gteq(z64f),z64f);
        }

        public void lt()
        {
            const string name = "lt";

            CheckBinaryPredMatch(predicate(math.lt, name, z8), GZ.lt(z8), z8);
            CheckBinaryPredMatch(predicate(math.lt, name, z8i), GZ.lt(z8i), z8i);
            
            CheckBinaryPredMatch(predicate(math.lt, name, z16), GZ.lt(z16),z16);
            CheckBinaryPredMatch(predicate(math.lt, name,z16i), GZ.lt(z16i),z16i);
            
            CheckBinaryPredMatch(predicate(math.lt, name,z32), GZ.lt(z32),z32);
            CheckBinaryPredMatch(predicate(math.lt, name,z32i), GZ.lt(z32i),z32i);
                        
            CheckBinaryPredMatch(predicate(math.lt, name,z64), GZ.lt(z64),z64);
            CheckBinaryPredMatch(predicate(math.lt, name,z64i), GZ.lt(z64i),z64i);

            CheckBinaryPredMatch(predicate(fmath.lt, name, z32f), GZ.lt(z32f),z32f);
            CheckBinaryPredMatch(predicate(fmath.lt, name,z64f), GZ.lt(z64f),z64f);

        }

        public void lteq()
        {
            const string name = "lteq";

            CheckBinaryPredMatch(predicate(math.lteq, name, z8), GZ.lteq(z8), z8);
            CheckBinaryPredMatch(predicate(math.lteq, name, z8i), GZ.lteq(z8i), z8i);
            
            CheckBinaryPredMatch(predicate(math.lteq, name, z16), GZ.lteq(z16),z16);
            CheckBinaryPredMatch(predicate(math.lteq, name,z16i), GZ.lteq(z16i),z16i);
            
            CheckBinaryPredMatch(predicate(math.lteq, name,z32), GZ.lteq(z32),z32);
            CheckBinaryPredMatch(predicate(math.lteq, name,z32i), GZ.lteq(z32i),z32i);
                        
            CheckBinaryPredMatch(predicate(math.lteq, name,z64), GZ.lteq(z64),z64);
            CheckBinaryPredMatch(predicate(math.lteq, name,z64i), GZ.lteq(z64i),z64i);

            CheckBinaryPredMatch(predicate(fmath.lteq, name, z32f), GZ.lteq(z32f),z32f);
            CheckBinaryPredMatch(predicate(fmath.lteq, name,z64f), GZ.lteq(z64f),z64f);

        }

    }
}