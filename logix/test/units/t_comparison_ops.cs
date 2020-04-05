//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;
    using static VCore;
    using static Core;

    using static VectorizedOps;
    
    using S = NumericOps;

    public class t_comparison_ops : TypedLogixTest<t_comparison_ops>
    {
        public void scalar_eq_op_check()
        {
            scalar_eq_op_check<byte>();
            scalar_eq_op_check<ushort>();
            scalar_eq_op_check<uint>();
            scalar_eq_op_check<ulong>();
        }

        public void scalar_lt_op_check()
        {
            scalar_lt_op_check<byte>();
            scalar_lt_op_check<ushort>();
            scalar_lt_op_check<uint>();
            scalar_lt_op_check<ulong>();
        }
        
        public void scalar_lteq_op_check()
        {
            scalar_lteq_op_check<byte>();
            scalar_lteq_op_check<ushort>();
            scalar_lteq_op_check<uint>();
            scalar_lteq_op_check<ulong>();
        }

        public void scalar_gt_op_check()
        {
            scalar_gt_op_check<byte>();
            scalar_gt_op_check<ushort>();
            scalar_gt_op_check<uint>();
            scalar_gt_op_check<ulong>();
        }
        
        public void scalar_gteq_op_check()
        {
            scalar_gteq_op_check<byte>();
            scalar_gteq_op_check<ushort>();
            scalar_gteq_op_check<uint>();
            scalar_gteq_op_check<ulong>();
        }

        public void cpu128_lt_op_check()
        {
            var n = n128;
            cpu_lt_op_check<byte>(n); 
            cpu_lt_op_check<sbyte>(n);
            cpu_lt_op_check<short>(n);
            cpu_lt_op_check<ushort>(n);
            cpu_lt_op_check<int>(n);
            cpu_lt_op_check<uint>(n);
            cpu_lt_op_check<long>(n);
            cpu_lt_op_check<ulong>(n);
        }

        public void cpu256_lt_op_check()
        {
            var n = n256;
            cpu_lt_op_check<byte>(n); 
            cpu_lt_op_check<sbyte>(n);
            cpu_lt_op_check<short>(n);
            cpu_lt_op_check<ushort>(n);
            cpu_lt_op_check<int>(n);
            cpu_lt_op_check<uint>(n);
            cpu_lt_op_check<long>(n);
            cpu_lt_op_check<ulong>(n);
        }

        public void cpu128_gt_op_check()
        {
            var n = n128;
            cpu_gt_op_check<byte>(n); 
            cpu_gt_op_check<sbyte>(n);
            cpu_gt_op_check<short>(n);
            cpu_gt_op_check<ushort>(n);
            cpu_gt_op_check<int>(n);
            cpu_gt_op_check<uint>(n);
            cpu_gt_op_check<long>(n);
            cpu_gt_op_check<ulong>(n);
        }

        public void cpu256_gt_op_check()
        {
            var n = n256;
            cpu_gt_op_check<byte>(n); 
            cpu_gt_op_check<sbyte>(n);
            cpu_gt_op_check<short>(n);
            cpu_gt_op_check<ushort>(n);
            cpu_gt_op_check<int>(n);
            cpu_gt_op_check<uint>(n);
            cpu_gt_op_check<long>(n);
            cpu_gt_op_check<ulong>(n);
        }


       void scalar_eq_op_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = gmath.inc(x);

                var y0 = gmath.eq(x,x);
                Claim.require(y0);

                var y1 = S.equals(x,x);
                Claim.eq(Core.maxval<T>(), y1);

                var y2 = gmath.eq(x,y);
                Claim.nea(y2);

                var y3 = S.equals(x,y);
                Claim.eq(Core.zero<T>(),y3);

            }
        }

        void cpu_lt_op_check<T>(N128 n)
            where T : unmanaged
        {
            var x = Random.CpuVector<T>(n);
            var y = Random.CpuVector<T>(n);
            var expect = vzero<T>(n);
            var actual = vzero<T>(n);
            for(var i=0; i< RepCount; i++)
            {                
                expect = gvec.vlt(x,y);
                actual = lt(x,y);
                Claim.require(same(expect,actual));

                var a =VCore.vbroadcast(n,Random.Next<T>());
                x = gvec.vxor(x,a);
                y = gvec.vxor(y,a);                
            }
        }

        void cpu_lt_op_check<T>(N256 n)
            where T : unmanaged
        {
            var x = Random.CpuVector<T>(n);
            var y = Random.CpuVector<T>(n);
            var expect = vzero<T>(n);
            var actual = vzero<T>(n);
            for(var i=0; i< RepCount; i++)
            {                
                expect = gvec.vlt(x,y);
                actual = lt(x,y);
                Claim.require(same(expect,actual));

                var a =VCore.vbroadcast(n,Random.Next<T>());
                x = gvec.vxor(x,a);
                y = gvec.vxor(y,a);                
            }

        }

        void cpu_gt_op_check<T>(N128 n)
            where T : unmanaged
        {
            var x = Random.CpuVector<T>(n);
            var y = Random.CpuVector<T>(n);
            var expect = vzero<T>(n);
            var actual = vzero<T>(n);
            for(var i=0; i< RepCount; i++)
            {                
                expect = gvec.vgt(x,y);
                actual = gt(x,y);
                Claim.require(same(expect,actual));

                var a =VCore.vbroadcast(n,Random.Next<T>());
                x = gvec.vxor(x,a);
                y = gvec.vxor(y,a);                
            }

        }

        void cpu_gt_op_check<T>(N256 n)
            where T : unmanaged
        {
            var x = Random.CpuVector<T>(n);
            var y = Random.CpuVector<T>(n);
            var expect = vzero<T>(n);
            var actual = vzero<T>(n);
            for(var i=0; i< RepCount; i++)
            {                
                expect = gvec.vgt(x,y);
                actual = gt(x,y);
                Claim.require(same(expect,actual));

                var a =VCore.vbroadcast(n,Random.Next<T>());
                x = gvec.vxor(x,a);
                y = gvec.vxor(y,a);                
            }

        }

        void scalar_lt_op_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                var expect = S.promote<T>(gmath.lt(x,y));
                var actual = S.lt(x,y);
                Claim.eq(expect,actual);
            }
        }

        void scalar_lteq_op_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                var expect = S.promote<T>(gmath.lteq(x,y));
                var actual = S.lteq(x,y);
                Claim.eq(expect,actual);
            }
        }

        void scalar_gt_op_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                var expect = S.promote<T>(gmath.gt(x,y));
                var actual = S.gt(x,y);
                Claim.eq(expect,actual);
            }
        }

        void scalar_gteq_op_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                var expect = S.promote<T>(gmath.gteq(x,y));
                var actual = S.gteq(x,y);
                Claim.eq(expect,actual);
            }
        }


    }

}