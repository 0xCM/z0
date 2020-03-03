//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static TypedLogicSpec;

    public class t_bitwise_expr : UnitTest<t_bitwise_expr>
    {
        public void check_not_scalar_expr()  
        {      
            check_scalar_expr<byte>(UnaryBitLogicKind.Not);
            check_scalar_expr<ushort>(UnaryBitLogicKind.Not);
            check_scalar_expr<uint>(UnaryBitLogicKind.Not);
            check_scalar_expr<ulong>(UnaryBitLogicKind.Not);
        }

        public void check_and_scalar_expr()
        {
            var op = BinaryBitLogicKind.And;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_or_scalar_expr()
        {
            var op = BinaryBitLogicKind.Or;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_xor_scalar_expr()
        {
            var op = BinaryBitLogicKind.Xor;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_nand_scalar_expr()
        {
            var op = BinaryBitLogicKind.Nand;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_nor_scalar_expr()
        {
            var op = BinaryBitLogicKind.Nor;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_xnor_scalar_expr()
        {
            var op = BinaryBitLogicKind.Xnor;

            check_scalar_expr<byte>(op);
            check_scalar_expr<ushort>(op);
            check_scalar_expr<uint>(op);
            check_scalar_expr<ulong>(op);
        }

        public void check_not_128_expr()
        {            
            var n = n128;
            var op = UnaryBitLogicKind.Not;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_and_128_expr()
        {            
            var n = n128;
            var op = BinaryBitLogicKind.And;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_or_128_expr()
        {            
            var n = n128;
            var op = BinaryBitLogicKind.Or;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xor_128_expr()
        {            
            var n = n128;
            var op = BinaryBitLogicKind.Xor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nand_128_expr()
        {            
            var n = n128;
            var op = BinaryBitLogicKind.Nand;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nor_128_expr()
        {            
            var n = n128;
            var op = BinaryBitLogicKind.Nor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xnor_128_expr()
        {            
            var n = n128;
            var op = BinaryBitLogicKind.Xnor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_not_256_expr()
        {            
            var n = n128;
            var op = UnaryBitLogicKind.Not;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_and_256_expr()
        {            
            var n = n256;
            var op = BinaryBitLogicKind.And;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_or_256_expr()
        {            
            var n = n256;
            var op = BinaryBitLogicKind.Or;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xor_256_expr()
        {            
            var n = n256;
            var op = BinaryBitLogicKind.Xor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nand_256_expr()
        {            
            var n = n256;
            var op = BinaryBitLogicKind.Nand;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_nor_256_expr()
        {            
            var n = n256;
            var op = BinaryBitLogicKind.Nor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }

        public void check_xnor_256_expr()
        {            
            var n = n256;
            var op = BinaryBitLogicKind.Xnor;
            check_cpu_expr<byte>(n, op);
            check_cpu_expr<ushort>(n, op);
            check_cpu_expr<uint>(n, op);
            check_cpu_expr<ulong>(n, op);
        }
        
        public void check_ternary_ops()
        {
            iter(Spans.set(
                VectorOpApi.TernaryBitLogicKinds, 
                ScalarOpApi.TernaryBitLogicKinds),
                    check_ternary_ops);
        }

        void check_ternary_ops(TernaryBitLogicKind op)
        {
            check_ternary_ops<byte>(op);
            check_ternary_ops<ushort>(op);
            check_ternary_ops<uint>(op);
            check_ternary_ops<ulong>(op);
        }

        void check_op_identity<T>(TernaryBitLogicKind id)
            where T: unmanaged
        {
            var a = convert<T>(0b1111_0000);
            var b = convert<T>(0b1100_1100);
            var c = convert<T>(0b1010_1010);
            var mask = convert<T>(0xFF);
            var f = ScalarOpApi.lookup<T>(id);
            var actual = convert<T,byte>(gmath.and(f(a,b,c), mask));
            var expect = (byte)id;
            Claim.eq(expect.FormatHex(), actual.FormatHex());
        }

        void check_ternary_ops<T>(TernaryBitLogicKind id)
            where T : unmanaged
        {
            var BL = LogicOpApi.lookup(id);
            var SC = ScalarOpApi.lookup<T>(id);
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
                if(!ScalarOps.same(z3, z0.Scalar))
                    Claim.failwith($"Evalutation of ternary op {id} failed");

                var v1 = CpuVector.vbroadcast(n256,sa);
                var v2 = CpuVector.vbroadcast(n256,sb);
                var v3 = CpuVector.vbroadcast(n256,sc);
                var v4 = Vector256.GetElement(V256(v1,v2,v3), 0);
                Claim.eq(v4,z3);


                var u1 = ginx.vlo(v1);
                var u2 = ginx.vlo(v2);
                var u3 = ginx.vlo(v3);
                var u4 = Vector128.GetElement(V128(u1,u2,u3),0);
                Claim.eq(u4, z3);
            }
        }

        void check_scalar_expr<T>(UnaryBitLogicKind kind)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var expr = unary(kind,v1);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);
                BitVector<T> actual = LogicEngine.eval(expr).Value;
                BitVector<T> expect = ScalarOpApi.eval(kind,a);
                Claim.eq(actual,expect);                                            
            }
        }

        void check_scalar_expr<T>(BinaryBitLogicKind op)
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
                T expect = ScalarOpApi.eval(op,a,b);
                T result1 = LogicEngine.eval(expr);
                T result2 = BitVectorOpApi.eval(op, BitVector.alloc(a),BitVector.alloc(b)).Scalar;
                Claim.eq(expect, result1);                            
                Claim.eq(expect, result2);                            
            }
        }

        void check_cpu_expr<T>(N128 n, UnaryBitLogicKind op)
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
                Claim.eq(actual,expect);                            
            }
        }

        void check_cpu_expr<T>(N256 n, UnaryBitLogicKind op)
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
                Claim.eq(actual,expect);                            
            }
        }

        void check_cpu_expr<T>(N128 n, BinaryBitLogicKind op)
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
                Claim.eq(actual,expect);                            
            }
        }

        void check_cpu_expr<T>(N256 n, BinaryBitLogicKind op)
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
                Claim.eq(actual,expect);                            
            }
        }
    }
}