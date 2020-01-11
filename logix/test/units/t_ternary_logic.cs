//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    public class t_ternary_logic : UnitTest<t_ternary_logic>
    {

        protected override int RepCount => Pow2.T08;
        
        IEnumerable<TernaryOpKind> TernaryKinds
            => ScalarOpApi.TernaryBitwiseKinds;
        
        public void op_identities()
        {                         
            foreach(var kind in TernaryKinds)
            {
                check_op_identity<byte>(kind);
                check_op_identity<ushort>(kind);
                check_op_identity<uint>(kind);
                check_op_identity<ulong>(kind);
            }
        }

        public void op_equivalence()
        {
            foreach(var kind in TernaryKinds)
            {
                check_op_equivalence<byte>(kind);
                check_op_equivalence<ushort>(kind);
                check_op_equivalence<uint>(kind);
                check_op_equivalence<ulong>(kind);
            }
        }

        public void op_select()
        {
            check_select<byte>();
            check_select<ushort>();
            check_select<uint>();
            check_select<ulong>();
            check_select<byte>(n128);
            check_select<ushort>(n128);
            check_select<uint>(n128);
            check_select<ulong>(n128);
            check_select<byte>(n256);
            check_select<ushort>(n256);
            check_select<uint>(n256);
            check_select<ulong>(n256);

        }

        void check_select<T>()
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var width = bitsize<T>();
                var a = Random.BitVector<T>();
                var b = Random.BitVector<T>();
                var c = Random.BitVector<T>();
                BitVector<T> x = ScalarOps.select(a.Scalar, b.Scalar, c.Scalar);
                for(var j=0; j<x.Width; j++)
                    Claim.eq(x[j], LogicOps.select(a[j],b[j],c[j]));
            }

        }

        void check_select<T>(N128 n = default)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.CpuVector<T>(n);
                var b = Random.CpuVector<T>(n);
                var c = Random.CpuVector<T>(n);
                var x = CpuOps.select(a,b,c);

                var sa = a.ToSpan();
                var sb = b.ToSpan();
                var sc = c.ToSpan();
                var sx = x.ToSpan();

                for(var j=0; j< sx.Length; j++)
                    Claim.eq(sx[j], ScalarOps.select(sa[j], sb[j], sc[j]));
            }

        }


        void check_select<T>(N256 n = default)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.CpuVector<T>(n);
                var b = Random.CpuVector<T>(n);
                var c = Random.CpuVector<T>(n);
                var x = CpuOps.select(a,b,c);

                var sa = a.ToSpan();
                var sb = b.ToSpan();
                var sc = c.ToSpan();
                var sx = x.ToSpan();

                for(var j=0; j< sx.Length; j++)
                    Claim.eq(sx[j], ScalarOps.select(sa[j], sb[j], sc[j]));
            }

        }

        void check_op_identity<T>(TernaryOpKind id)
            where T: unmanaged
        {
            var a = convert<T>(0b1111_0000);
            var b = convert<T>(0b1100_1100);
            var c = convert<T>(0b1010_1010);
            var d = convert<T>(0b1111_1111);
            var f = ScalarOpApi.lookup<T>(id);
            var actual = convert<T,byte>(gmath.and(f(a,b,c), d));
            var expect = (byte)id;
            Claim.eq(expect.FormatHex(), actual.FormatHex());
        }


        void check_op_equivalence<T>(TernaryOpKind kind)
            where T: unmanaged
        {
            var width = bitsize<T>();
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.BitVector<T>();
                var b = Random.BitVector<T>();
                var c = Random.BitVector<T>();
                var u = BitVector.alloc<T>();

                for(var j=0; j<width; j++)
                    u[j] = LogicOpApi.eval(kind, a[j], b[j], c[j]);
                
                
                BitVector<T> v = ScalarOpApi.eval(kind, a.Scalar, b.Scalar, c.Scalar);

                if(u != v)
                    Trace($"Equivalence failed for ternary op {kind}:{primalsig<T>()}");

                Claim.eq(u,v);

            }
        }
    }
}