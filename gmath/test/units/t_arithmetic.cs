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
    
    public class t_arithmetic : t_gmath<t_arithmetic>
    {
        public void check_add()
        {
            const string name = "add";

            CheckBinaryPredMatch(binary(math.add, name, z8), GZ.add(z8), z8);
            CheckBinaryPredMatch(binary(math.add, name, z8i), GZ.add(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.add, name, z16), GZ.add(z16),z16);
            CheckBinaryPredMatch(binary(math.add, name,z16i), GZ.add(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.add, name,z32), GZ.add(z32),z32);
            CheckBinaryPredMatch(binary(math.add, name,z32i), GZ.add(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.add, name,z64), GZ.add(z64),z64);
            CheckBinaryPredMatch(binary(math.add, name,z64i), GZ.add(z64i),z64i);

            CheckBinaryPredMatch(binary(fmath.add, name,z32f), GZ.add(z32f),z32f);
            CheckBinaryPredMatch(binary(fmath.add, name,z64f), GZ.add(z64f),z64f);
        }        

        public void check_sub()
        {
            const string name = "sub";

            CheckBinaryPredMatch(binary(math.sub, name, z8), GZ.sub(z8), z8);
            CheckBinaryPredMatch(binary(math.sub, name, z8i), GZ.sub(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.sub, name, z16), GZ.sub(z16),z16);
            CheckBinaryPredMatch(binary(math.sub, name,z16i), GZ.sub(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.sub, name,z32), GZ.sub(z32),z32);
            CheckBinaryPredMatch(binary(math.sub, name,z32i), GZ.sub(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.sub, name,z64), GZ.sub(z64),z64);
            CheckBinaryPredMatch(binary(math.sub, name,z64i), GZ.sub(z64i),z64i);

            CheckBinaryPredMatch(binary(fmath.sub, name,z32f), GZ.sub(z32f),z32f);
            CheckBinaryPredMatch(binary(fmath.sub, name,z64f), GZ.sub(z64f),z64f);
        }

        public void check_mul()
        {
            const string name = "mul";

            CheckBinaryPredMatch(binary(math.mul, name, z8), GZ.mul(z8), z8);
            CheckBinaryPredMatch(binary(math.mul, name, z8i), GZ.mul(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.mul, name, z16), GZ.mul(z16),z16);
            CheckBinaryPredMatch(binary(math.mul, name,z16i), GZ.mul(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.mul, name,z32), GZ.mul(z32),z32);
            CheckBinaryPredMatch(binary(math.mul, name,z32i), GZ.mul(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.mul, name,z64), GZ.mul(z64),z64);
            CheckBinaryPredMatch(binary(math.mul, name,z64i), GZ.mul(z64i),z64i);

            CheckBinaryPredMatch(binary(fmath.mul, name,z32f), GZ.mul(z32f),z32f);
            CheckBinaryPredMatch(binary(fmath.mul, name,z64f), GZ.mul(z64f),z64f);
        }

        public void check_div()
        {
            const string name = "div";

            CheckBinaryPredMatch(binary(math.div, name, z8), GZ.div(z8), z8,true);
            CheckBinaryPredMatch(binary(math.div, name, z8i), GZ.div(z8i), z8i,true);
            
            CheckBinaryPredMatch(binary(math.div, name, z16), GZ.div(z16),z16,true);
            CheckBinaryPredMatch(binary(math.div, name,z16i), GZ.div(z16i),z16i,true);
            
            CheckBinaryPredMatch(binary(math.div, name,z32), GZ.div(z32),z32,true);
            CheckBinaryPredMatch(binary(math.div, name,z32i), GZ.div(z32i),z32i,true);
                        
            CheckBinaryPredMatch(binary(math.div, name,z64), GZ.div(z64),z64,true);
            CheckBinaryPredMatch(binary(math.div, name,z64i), GZ.div(z64i),z64i,true);

            CheckBinaryPredMatch(binary(fmath.div, name, z32f), GZ.div(z32f),z32f,true);
            CheckBinaryPredMatch(binary(fmath.div, name,z64f), GZ.div(z64f),z64f,true);
        }

        public void check_mod()
        {
            const string name = "mod";

            CheckBinaryPredMatch(binary(math.mod, name, z8), GZ.mod(z8), z8,true);
            CheckBinaryPredMatch(binary(math.mod, name, z8i), GZ.mod(z8i), z8i,true);
            
            CheckBinaryPredMatch(binary(math.mod, name, z16), GZ.mod(z16),z16,true);
            CheckBinaryPredMatch(binary(math.mod, name,z16i), GZ.mod(z16i),z16i,true);
            
            CheckBinaryPredMatch(binary(math.mod, name,z32), GZ.mod(z32),z32,true);
            CheckBinaryPredMatch(binary(math.mod, name,z32i), GZ.mod(z32i),z32i,true);
                        
            CheckBinaryPredMatch(binary(math.mod, name,z64), GZ.mod(z64),z64,true);
            CheckBinaryPredMatch(binary(math.mod, name,z64i), GZ.mod(z64i),z64i,true);

            CheckBinaryPredMatch(binary(fmath.mod, name, z32f), GZ.mod(z32f),z32f,true);
            CheckBinaryPredMatch(binary(fmath.mod, name,z64f), GZ.mod(z64f),z64f,true);
        }

        public void check_modmul()
        {
            const string name = "modmul";

            CheckTernaryMatch(ternary(math.modmul, name, z8), GZ.modmul(z8), z8,true);
            CheckTernaryMatch(ternary(math.modmul, name, z8i), GZ.modmul(z8i), z8i,true);
            
            CheckTernaryMatch(ternary(math.modmul, name, z16), GZ.modmul(z16),z16,true);
            CheckTernaryMatch(ternary(math.modmul, name,z16i), GZ.modmul(z16i),z16i,true);
            
            CheckTernaryMatch(ternary(math.modmul, name,z32), GZ.modmul(z32),z32,true);
            CheckTernaryMatch(ternary(math.modmul, name,z32i), GZ.modmul(z32i),z32i,true);
                        
            CheckTernaryMatch(ternary(math.modmul, name,z64), GZ.modmul(z64),z64,true);
            CheckTernaryMatch(ternary(math.modmul, name,z64i), GZ.modmul(z64i),z64i,true);
        }

        public void check_clamp()
        {
            const string name = "clamp";

            CheckBinaryPredMatch(binary(math.clamp, name, z8), GZ.clamp(z8), z8);
            CheckBinaryPredMatch(binary(math.clamp, name, z8i), GZ.clamp(z8i), z8i);
            
            CheckBinaryPredMatch(binary(math.clamp, name, z16), GZ.clamp(z16),z16);
            CheckBinaryPredMatch(binary(math.clamp, name,z16i), GZ.clamp(z16i),z16i);
            
            CheckBinaryPredMatch(binary(math.clamp, name,z32), GZ.clamp(z32),z32);
            CheckBinaryPredMatch(binary(math.clamp, name,z32i), GZ.clamp(z32i),z32i);
                        
            CheckBinaryPredMatch(binary(math.clamp, name,z64), GZ.clamp(z64),z64);
            CheckBinaryPredMatch(binary(math.clamp, name,z64i), GZ.clamp(z64i),z64i);

            CheckBinaryPredMatch(binary(fmath.clamp, name,z32f), GZ.clamp(z32f),z32f);
            CheckBinaryPredMatch(binary(fmath.clamp, name,z64f), GZ.clamp(z64f),z64f);
        }

        public void check_inc()
        {
            const string name = "inc";

            CheckUnaryMatch(unary(math.inc, name, z8), GZ.inc(z8), z8);
            CheckUnaryMatch(unary(math.inc, name, z8i), GZ.inc(z8i), z8i);
            
            CheckUnaryMatch(unary(math.inc, name, z16), GZ.inc(z16),z16);
            CheckUnaryMatch(unary(math.inc, name,z16i), GZ.inc(z16i),z16i);
            
            CheckUnaryMatch(unary(math.inc, name,z32), GZ.inc(z32),z32);
            CheckUnaryMatch(unary(math.inc, name,z32i), GZ.inc(z32i),z32i);
                        
            CheckUnaryMatch(unary(math.inc, name,z64), GZ.inc(z64),z64);
            CheckUnaryMatch(unary(math.inc, name,z64i), GZ.inc(z64i),z64i);

            CheckUnaryMatch(unary(fmath.inc, name, z32f), GZ.inc(z32f),z32f);
            CheckUnaryMatch(unary(fmath.inc, name,z64f), GZ.inc(z64f),z64f);
        }

        public void check_dec()
        {
            const string name = "dec";

            CheckUnaryMatch(unary(math.dec, name, z8), GZ.dec(z8), z8);
            CheckUnaryMatch(unary(math.dec, name, z8i), GZ.dec(z8i), z8i);
            
            CheckUnaryMatch(unary(math.dec, name, z16), GZ.dec(z16),z16);
            CheckUnaryMatch(unary(math.dec, name,z16i), GZ.dec(z16i),z16i);
            
            CheckUnaryMatch(unary(math.dec, name,z32), GZ.dec(z32),z32);
            CheckUnaryMatch(unary(math.dec, name,z32i), GZ.dec(z32i),z32i);
                        
            CheckUnaryMatch(unary(math.dec, name,z64), GZ.dec(z64),z64);
            CheckUnaryMatch(unary(math.dec, name,z64i), GZ.dec(z64i),z64i);

            CheckUnaryMatch(unary(fmath.dec, name, z32f), GZ.dec(z32f),z32f);
            CheckUnaryMatch(unary(fmath.dec, name,z64f), GZ.dec(z64f),z64f);
        }

        public void check_negate()
        {
            const string name = "negate";

            CheckUnaryMatch(unary(math.negate, name, z8), GZ.negate(z8), z8);
            CheckUnaryMatch(unary(math.negate, name, z8i), GZ.negate(z8i), z8i);
            
            CheckUnaryMatch(unary(math.negate, name, z16), GZ.negate(z16),z16);
            CheckUnaryMatch(unary(math.negate, name,z16i), GZ.negate(z16i),z16i);
            
            CheckUnaryMatch(unary(math.negate, name,z32), GZ.negate(z32),z32);
            CheckUnaryMatch(unary(math.negate, name,z32i), GZ.negate(z32i),z32i);
                        
            CheckUnaryMatch(unary(math.negate, name,z64), GZ.negate(z64),z64);
            CheckUnaryMatch(unary(math.negate, name,z64i), GZ.negate(z64i),z64i);

            CheckUnaryMatch(unary(fmath.negate, name, z32f), GZ.negate(z32f),z32f);
            CheckUnaryMatch(unary(fmath.negate, name,z64f), GZ.negate(z64f),z64f);
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

            CheckUnaryMatch(unary(math.abs, name, z8i), GZ.abs(z8i), z8i);            
            CheckUnaryMatch(unary(math.abs, name,z16i), GZ.abs(z16i),z16i);            
            CheckUnaryMatch(unary(math.abs, name,z32i), GZ.abs(z32i),z32i);                        
            CheckUnaryMatch(unary(math.abs, name,z64i), GZ.abs(z64i),z64i);
            CheckUnaryMatch(unary(fmath.abs, name, z32f), GZ.abs(z32f),z32f);
            CheckUnaryMatch(unary(fmath.abs, name,z64f), GZ.abs(z64f),z64f);
        }

        public void check_increments()
        {
            const string name = "increments";
            CheckAction(() => check_increments(z8), name, z8);
            CheckAction(() => check_increments(z8i), name, z8i);
            CheckAction(() => check_increments(z16), name, z16);
            CheckAction(() => check_increments(z16i), name, z16i);
            CheckAction(() => check_increments(z32), name, z32);
            CheckAction(() => check_increments(z32i), name, z32i);
            CheckAction(() => check_increments(z64), name, z64);
            CheckAction(() => check_increments(z64i), name, z64i);
        }

        void check_increments<T>(T first = default)
            where T : unmanaged
        {
            var count = Random.Next(21, 256);
            Span<T> data = new T[count];
            ref var src = ref head(data);
            gmath.increments(first, count, ref src);
            
            for(var i=0; i < count; i++)
                Claim.eq(gmath.add(first, convert<T>(i)), data[i]);
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
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();
                var expect = gmath.lt(x, zero) ? Sign.Neg : (gmath.gt(x, zero) ? Sign.Pos : Sign.None);
                var actual = gmath.signum(x);
                Claim.eq(expect,actual);
            }
        }
    }
}