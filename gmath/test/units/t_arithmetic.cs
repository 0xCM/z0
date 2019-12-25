//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_arithmetic : t_gmath<t_arithmetic>
    {
        public void check_add()
        {
            const string name = "add";

            check_binary_match(ZOps.binary(math.add, name, z8), KOps.add(z8), z8);
            check_binary_match(ZOps.binary(math.add, name, z8i), KOps.add(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.add, name, z16), KOps.add(z16),z16);
            check_binary_match(ZOps.binary(math.add, name,z16i), KOps.add(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.add, name,z32), KOps.add(z32),z32);
            check_binary_match(ZOps.binary(math.add, name,z32i), KOps.add(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.add, name,z64), KOps.add(z64),z64);
            check_binary_match(ZOps.binary(math.add, name,z64i), KOps.add(z64i),z64i);

            check_binary_match(ZOps.binary(fmath.add, name,z32f), KOps.add(z32f),z32f);
            check_binary_match(ZOps.binary(fmath.add, name,z64f), KOps.add(z64f),z64f);
        }

        public void check_sub()
        {
            const string name = "sub";

            check_binary_match(ZOps.binary(math.sub, name, z8), KOps.sub(z8), z8);
            check_binary_match(ZOps.binary(math.sub, name, z8i), KOps.sub(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.sub, name, z16), KOps.sub(z16),z16);
            check_binary_match(ZOps.binary(math.sub, name,z16i), KOps.sub(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.sub, name,z32), KOps.sub(z32),z32);
            check_binary_match(ZOps.binary(math.sub, name,z32i), KOps.sub(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.sub, name,z64), KOps.sub(z64),z64);
            check_binary_match(ZOps.binary(math.sub, name,z64i), KOps.sub(z64i),z64i);

            check_binary_match(ZOps.binary(fmath.sub, name,z32f), KOps.sub(z32f),z32f);
            check_binary_match(ZOps.binary(fmath.sub, name,z64f), KOps.sub(z64f),z64f);
        }

        public void check_mul()
        {
            const string name = "mul";

            check_binary_match(ZOps.binary(math.mul, name, z8), KOps.mul(z8), z8);
            check_binary_match(ZOps.binary(math.mul, name, z8i), KOps.mul(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.mul, name, z16), KOps.mul(z16),z16);
            check_binary_match(ZOps.binary(math.mul, name,z16i), KOps.mul(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.mul, name,z32), KOps.mul(z32),z32);
            check_binary_match(ZOps.binary(math.mul, name,z32i), KOps.mul(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.mul, name,z64), KOps.mul(z64),z64);
            check_binary_match(ZOps.binary(math.mul, name,z64i), KOps.mul(z64i),z64i);

            check_binary_match(ZOps.binary(fmath.mul, name,z32f), KOps.mul(z32f),z32f);
            check_binary_match(ZOps.binary(fmath.mul, name,z64f), KOps.mul(z64f),z64f);
        }

        public void check_div()
        {
            const string name = "div";

            check_binary_match(ZOps.binary(math.div, name, z8), KOps.div(z8), z8,true);
            check_binary_match(ZOps.binary(math.div, name, z8i), KOps.div(z8i), z8i,true);
            
            check_binary_match(ZOps.binary(math.div, name, z16), KOps.div(z16),z16,true);
            check_binary_match(ZOps.binary(math.div, name,z16i), KOps.div(z16i),z16i,true);
            
            check_binary_match(ZOps.binary(math.div, name,z32), KOps.div(z32),z32,true);
            check_binary_match(ZOps.binary(math.div, name,z32i), KOps.div(z32i),z32i,true);
                        
            check_binary_match(ZOps.binary(math.div, name,z64), KOps.div(z64),z64,true);
            check_binary_match(ZOps.binary(math.div, name,z64i), KOps.div(z64i),z64i,true);

            check_binary_match(ZOps.binary(fmath.div, name, z32f), KOps.div(z32f),z32f,true);
            check_binary_match(ZOps.binary(fmath.div, name,z64f), KOps.div(z64f),z64f,true);
        }

        public void check_mod()
        {
            const string name = "mod";

            check_binary_match(ZOps.binary(math.mod, name, z8), KOps.mod(z8), z8,true);
            check_binary_match(ZOps.binary(math.mod, name, z8i), KOps.mod(z8i), z8i,true);
            
            check_binary_match(ZOps.binary(math.mod, name, z16), KOps.mod(z16),z16,true);
            check_binary_match(ZOps.binary(math.mod, name,z16i), KOps.mod(z16i),z16i,true);
            
            check_binary_match(ZOps.binary(math.mod, name,z32), KOps.mod(z32),z32,true);
            check_binary_match(ZOps.binary(math.mod, name,z32i), KOps.mod(z32i),z32i,true);
                        
            check_binary_match(ZOps.binary(math.mod, name,z64), KOps.mod(z64),z64,true);
            check_binary_match(ZOps.binary(math.mod, name,z64i), KOps.mod(z64i),z64i,true);

            check_binary_match(ZOps.binary(fmath.mod, name, z32f), KOps.mod(z32f),z32f,true);
            check_binary_match(ZOps.binary(fmath.mod, name,z64f), KOps.mod(z64f),z64f,true);
        }

        public void check_modmul()
        {
            const string name = "modmul";

            check_ternary_match(ZOps.ternary(math.modmul, name, z8), KOps.modmul(z8), z8,true);
            check_ternary_match(ZOps.ternary(math.modmul, name, z8i), KOps.modmul(z8i), z8i,true);
            
            check_ternary_match(ZOps.ternary(math.modmul, name, z16), KOps.modmul(z16),z16,true);
            check_ternary_match(ZOps.ternary(math.modmul, name,z16i), KOps.modmul(z16i),z16i,true);
            
            check_ternary_match(ZOps.ternary(math.modmul, name,z32), KOps.modmul(z32),z32,true);
            check_ternary_match(ZOps.ternary(math.modmul, name,z32i), KOps.modmul(z32i),z32i,true);
                        
            check_ternary_match(ZOps.ternary(math.modmul, name,z64), KOps.modmul(z64),z64,true);
            check_ternary_match(ZOps.ternary(math.modmul, name,z64i), KOps.modmul(z64i),z64i,true);
        }

        public void check_clamp()
        {
            const string name = "clamp";

            check_binary_match(ZOps.binary(math.clamp, name, z8), KOps.clamp(z8), z8);
            check_binary_match(ZOps.binary(math.clamp, name, z8i), KOps.clamp(z8i), z8i);
            
            check_binary_match(ZOps.binary(math.clamp, name, z16), KOps.clamp(z16),z16);
            check_binary_match(ZOps.binary(math.clamp, name,z16i), KOps.clamp(z16i),z16i);
            
            check_binary_match(ZOps.binary(math.clamp, name,z32), KOps.clamp(z32),z32);
            check_binary_match(ZOps.binary(math.clamp, name,z32i), KOps.clamp(z32i),z32i);
                        
            check_binary_match(ZOps.binary(math.clamp, name,z64), KOps.clamp(z64),z64);
            check_binary_match(ZOps.binary(math.clamp, name,z64i), KOps.clamp(z64i),z64i);

            check_binary_match(ZOps.binary(fmath.clamp, name,z32f), KOps.clamp(z32f),z32f);
            check_binary_match(ZOps.binary(fmath.clamp, name,z64f), KOps.clamp(z64f),z64f);
        }

        public void check_inc()
        {
            const string name = "inc";

            check_unary_match(ZOps.unary(math.inc, name, z8), KOps.inc(z8), z8);
            check_unary_match(ZOps.unary(math.inc, name, z8i), KOps.inc(z8i), z8i);
            
            check_unary_match(ZOps.unary(math.inc, name, z16), KOps.inc(z16),z16);
            check_unary_match(ZOps.unary(math.inc, name,z16i), KOps.inc(z16i),z16i);
            
            check_unary_match(ZOps.unary(math.inc, name,z32), KOps.inc(z32),z32);
            check_unary_match(ZOps.unary(math.inc, name,z32i), KOps.inc(z32i),z32i);
                        
            check_unary_match(ZOps.unary(math.inc, name,z64), KOps.inc(z64),z64);
            check_unary_match(ZOps.unary(math.inc, name,z64i), KOps.inc(z64i),z64i);

            check_unary_match(ZOps.unary(fmath.inc, name, z32f), KOps.inc(z32f),z32f);
            check_unary_match(ZOps.unary(fmath.inc, name,z64f), KOps.inc(z64f),z64f);
        }

        public void check_dec()
        {
            const string name = "dec";

            check_unary_match(ZOps.unary(math.dec, name, z8), KOps.dec(z8), z8);
            check_unary_match(ZOps.unary(math.dec, name, z8i), KOps.dec(z8i), z8i);
            
            check_unary_match(ZOps.unary(math.dec, name, z16), KOps.dec(z16),z16);
            check_unary_match(ZOps.unary(math.dec, name,z16i), KOps.dec(z16i),z16i);
            
            check_unary_match(ZOps.unary(math.dec, name,z32), KOps.dec(z32),z32);
            check_unary_match(ZOps.unary(math.dec, name,z32i), KOps.dec(z32i),z32i);
                        
            check_unary_match(ZOps.unary(math.dec, name,z64), KOps.dec(z64),z64);
            check_unary_match(ZOps.unary(math.dec, name,z64i), KOps.dec(z64i),z64i);

            check_unary_match(ZOps.unary(fmath.dec, name, z32f), KOps.dec(z32f),z32f);
            check_unary_match(ZOps.unary(fmath.dec, name,z64f), KOps.dec(z64f),z64f);
        }

        public void check_negate()
        {
            const string name = "negate";

            check_unary_match(ZOps.unary(math.negate, name, z8), KOps.negate(z8), z8);
            check_unary_match(ZOps.unary(math.negate, name, z8i), KOps.negate(z8i), z8i);
            
            check_unary_match(ZOps.unary(math.negate, name, z16), KOps.negate(z16),z16);
            check_unary_match(ZOps.unary(math.negate, name,z16i), KOps.negate(z16i),z16i);
            
            check_unary_match(ZOps.unary(math.negate, name,z32), KOps.negate(z32),z32);
            check_unary_match(ZOps.unary(math.negate, name,z32i), KOps.negate(z32i),z32i);
                        
            check_unary_match(ZOps.unary(math.negate, name,z64), KOps.negate(z64),z64);
            check_unary_match(ZOps.unary(math.negate, name,z64i), KOps.negate(z64i),z64i);

            check_unary_match(ZOps.unary(fmath.negate, name, z32f), KOps.negate(z32f),z32f);
            check_unary_match(ZOps.unary(fmath.negate, name,z64f), KOps.negate(z64f),z64f);
        }

        public void negate_exemplars()
        {
            var x1 = 128ul;
            var y1 = 18446744073709551488;
            var z1 = gmath.negate(x1);
            Claim.eq(y1,z1);            

            var x2 = 128u;
            var y2 = 4294967168u;
            var z2 = gmath.negate(x2);
            Claim.eq(y2,z2);            

            var x3 = (ushort)128;
            var y3 = (ushort)65408;
            var z3 = gmath.negate(x3);
            Claim.eq(y3,z3);            

            var x4 = (byte)128;
            var y4 = (byte)128;
            var z4 = gmath.negate(x4);
            Claim.eq(y4,z4);            

        }

        public void check_abs()
        {
            const string name = "abs";

            check_unary_match(ZOps.unary(math.abs, name, z8i), KOps.abs(z8i), z8i);            
            check_unary_match(ZOps.unary(math.abs, name,z16i), KOps.abs(z16i),z16i);            
            check_unary_match(ZOps.unary(math.abs, name,z32i), KOps.abs(z32i),z32i);                        
            check_unary_match(ZOps.unary(math.abs, name,z64i), KOps.abs(z64i),z64i);
            check_unary_match(ZOps.unary(fmath.abs, name, z32f), KOps.abs(z32f),z32f);
            check_unary_match(ZOps.unary(fmath.abs, name,z64f), KOps.abs(z64f),z64f);
        }

        public void signum_8i()
            => signum_check<sbyte>();

        public void signum_16i()
            => signum_check<short>();

        public void signum_32i()
            => signum_check<int>();

        public void signum_64i()
            => signum_check<long>();

        public void signum_32f()
            => signum_check<float>();

        public void signum_64f()
            => signum_check<double>();


        protected void signum_check<T>(T t = default)
            where T : unmanaged
        {
            var zero = gmath.zero<T>();
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.Next<T>();
                var expect = gmath.lt(x, zero) ? Sign.Neg : (gmath.gt(x, zero) ? Sign.Pos : Sign.None);
                var actual = gmath.signum(x);
                Claim.eq(expect,actual);
            }
        }
 
    }
}