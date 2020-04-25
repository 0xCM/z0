//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Memories;
    using static TypedLogicSpec;

    public class t_bitwise_expr : UnitTest<t_bitwise_expr, ICheckVectorBits>
    {
        protected override ICheckVectorBits Claim => CheckVectorBits.Checker;        

        public void check_not_scalar_expr()  
        {      
            check_scalar_expr<byte>(UnaryLogicKind.Not);
            check_scalar_expr<ushort>(UnaryLogicKind.Not);
            check_scalar_expr<uint>(UnaryLogicKind.Not);
            check_scalar_expr<ulong>(UnaryLogicKind.Not);
        }

        public void check_and_scalar_expr()
        {
            var op = BinaryLogicKind.And;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_or_scalar_expr()
        {
            var op = BinaryLogicKind.Or;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_xor_scalar_expr()
        {
            var op = BinaryLogicKind.Xor;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_nand_scalar_expr()
        {
            var op = BinaryLogicKind.Nand;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_nor_scalar_expr()
        {
            var op = BinaryLogicKind.Nor;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_xnor_scalar_expr()
        {
            var op = BinaryLogicKind.Xnor;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_not_128_expr()
        {            
            var n = n128;
            var op = UnaryLogicKind.Not;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_and_128_expr()
        {            
            var n = n128;
            var op = BinaryLogicKind.And;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_or_128_expr()
        {            
            var n = n128;
            var op = BinaryLogicKind.Or;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xor_128_expr()
        {            
            var n = n128;
            var op = BinaryLogicKind.Xor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nand_128_expr()
        {            
            var n = n128;
            var op = BinaryLogicKind.Nand;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nor_128_expr()
        {            
            var n = n128;
            var op = BinaryLogicKind.Nor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xnor_128_expr()
        {            
            var n = n128;
            var op = BinaryLogicKind.Xnor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_not_256_expr()
        {            
            var n = n128;
            var op = UnaryLogicKind.Not;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_and_256_expr()
        {            
            var n = n256;
            var op = BinaryLogicKind.And;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_or_256_expr()
        {            
            var n = n256;
            var op = BinaryLogicKind.Or;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xor_256_expr()
        {            
            var n = n256;
            var op = BinaryLogicKind.Xor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nand_256_expr()
        {            
            var n = n256;
            var op = BinaryLogicKind.Nand;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nor_256_expr()
        {            
            var n = n256;
            var op = BinaryLogicKind.Nor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xnor_256_expr()
        {            
            var n = n256;
            var op = BinaryLogicKind.Xnor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }
        
        public void check_ternary_ops()
        {
            Control.iter(Spans.set(VectorOpApi.TernaryBitLogicKinds, NumericOpApi.TernaryLogicKinds),
                check_ternary_ops);
        }

        void check_ternary_ops(TernaryLogicKind op)
        {
            check_ternary_ops<byte>(op);
            check_ternary_ops<ushort>(op);
            check_ternary_ops<uint>(op);
            check_ternary_ops<ulong>(op);
        }

        void check_op_identity<T>(TernaryLogicKind id)
            where T: unmanaged
        {
            var a = convert<T>(0b1111_0000);
            var b = convert<T>(0b1100_1100);
            var c = convert<T>(0b1010_1010);
            var mask = convert<T>(0xFF);
            var f = NumericOpApi.lookup<T>(id);
            var actual = convert<T,byte>(gmath.and(f(a,b,c), mask));
            var expect = (byte)id;
            Claim.eq(expect.FormatHex(), actual.FormatHex());
        }

        void check_ternary_ops<T>(TernaryLogicKind id)
            where T : unmanaged
        {
            var BL = BitLogix.lookup(id);
            var SC = NumericOpApi.lookup<T>(id);
            var V128 = VectorOpApi.lookup<T>(n128,id);
            var V256 = VectorOpApi.lookup<T>(n256,id);
            check_op_identity<T>(id);

            for(var sample = 0; sample< RepCount; sample++)
            {
                var sa = Random.Next<T>();
                var sb = Random.Next<T>();
                var sc = Random.Next<T>();

                var z0 = BitVector.alloc<T>();
                var va = BitVector.alloc(sa);
                var vb = BitVector.alloc(sb);
                var vc = BitVector.alloc(sc);
                for(var i=0; i< z0.Width; i++)
                    z0[i] = BL(va[i],vb[i],vc[i]);

                var z3 = SC(sa, sb, sc);
                if(!NumericOps.same(z3, z0.Scalar))
                    Claim.FailWith($"Evalutation of ternary op {id} failed");

                var v1 = Vectors.vbroadcast(n256,sa);
                var v2 = Vectors.vbroadcast(n256,sb);
                var v3 = Vectors.vbroadcast(n256,sc);
                var v4 = Vector256.GetElement(V256(v1,v2,v3), 0);
                Claim.eq(v4,z3);


                var u1 = gvec.vlo(v1);
                var u2 = gvec.vlo(v2);
                var u3 = gvec.vlo(v3);
                var u4 = Vector128.GetElement(V128(u1,u2,u3),0);
                Claim.eq(u4, z3);
            }
        }

        void check_scalar_expr<T>(UnaryLogicKind kind)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var expr = unary(kind,v1);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);
                BitVector<T> actual = LogicEngine.eval(expr).Value;
                BitVector<T> expect = NumericOpApi.eval(kind,a);
                Claim.eq(actual,expect);                                            
            }
        }

        void check_scalar_expr<T>(BinaryLogicKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var v2 = variable<T>(2);
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                v1.Set(a);
                v2.Set(b);
                T expect = NumericOpApi.eval(op,a,b);
                T result1 = LogicEngine.eval(expr);
                //T result2 = BitVectorOpApi.eval(op, BitVector.alloc(a),BitVector.alloc(b)).Scalar;
                var result2 = BitVectorLogix.Service.EvalDirect(op, BitVector.alloc(a),BitVector.alloc(b)).Scalar;
                Claim.eq(expect, result1);                            
                Claim.eq(expect, result2);                            
            }
        }

        void check_cpu_expr<T>(N128 n, UnaryLogicKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var expr = unary(op,v1);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n128);
                v1.Set(a);   
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = VectorOpApi.eval(op,a);
                Claim.veq(actual,expect);                            
            }
        }

        void check_cpu_expr<T>(N256 n, UnaryLogicKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            var expr = unary(op,v1);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n256);
                v1.Set(a);   
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = VectorOpApi.eval(op,a);
                Claim.veq(actual,expect);                            
            }
        }

        void check_cpu_expr<T>(N128 n, BinaryLogicKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var v2 = variable(2, default(Vector128<T>));
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n128);
                var b = Random.CpuVector<T>(n128);
                v1.Set(a);   
                v2.Set(b);
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = VectorOpApi.eval(op,a,b);
                Claim.veq(actual,expect);                            
            }
        }

        void check_cpu_expr<T>(N256 n, BinaryLogicKind op)
            where T : unmanaged
        {
            
            var v1 = variable(1, default(Vector256<T>));
            var v2 = variable(2, default(Vector256<T>));
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n256);
                var b = Random.CpuVector<T>(n256);
                v1.Set(a);   
                v2.Set(b);
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = VectorOpApi.eval(op,a,b);
                Claim.veq(actual,expect);                            
            }
        }
    }
}