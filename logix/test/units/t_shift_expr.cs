//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static TypedLogicSpec;
    using static LogicEngine;
    
    using static zfunc;

    public class t_shift_expr : TypedLogixTest<t_shift_expr>
    {        
       // ~ sll

        public void sll_8u()
            => check_op<byte>(ShiftKind.Sll);

        public void sll_128x8u()
            => check_op_128<byte>(ShiftKind.Sll);

        public void sll_256x8u()
            => check_op_256<byte>(ShiftKind.Sll);

        public void sll_32u()
            => check_op<uint>(ShiftKind.Sll);

        public void sll_128x32u()
            => check_op_128<uint>(ShiftKind.Sll);

        public void sll_256x32u()
            => check_op_256<uint>(ShiftKind.Sll);

        public void sll_64u()
            => check_op<ulong>(ShiftKind.Sll);

        public void sll_128x64u()
            => check_op_128<ulong>(ShiftKind.Sll);

        public void sll_256x64u()
            => check_op_256<ulong>(ShiftKind.Sll);

        // ~ srl

        public void srl_8u()
            => check_op<byte>(ShiftKind.Srl);

        public void srl_128x8u()
            => check_op_128<byte>(ShiftKind.Srl);

        public void srl_256x8u()
            => check_op_256<byte>(ShiftKind.Srl);

        public void check_srl_32u()
            => check_op<uint>(ShiftKind.Srl);

        public void srl_128x32u()
            => check_op_128<uint>(ShiftKind.Srl);

        public void srl_256x32u()
            => check_op_256<uint>(ShiftKind.Srl);

        public void check_srl_64u()
            => check_op<ulong>(ShiftKind.Srl);

        public void srl_128x64u()
            => check_op_128<ulong>(ShiftKind.Srl);

        public void srl_256x64u()
            => check_op_256<ulong>(ShiftKind.Srl);

        // ~ rotl

        public void rotl_8u()
            => check_op<byte>(ShiftKind.Rotl);

        public void rotl_128x8u()
            => check_op_128<byte>(ShiftKind.Rotl);

        public void rotl_256x8u()
            => check_op_256<byte>(ShiftKind.Rotl);

        public void rotl_32u()
            => check_op<uint>(ShiftKind.Rotl);

        public void rotl_128x32u()
            => check_op_128<uint>(ShiftKind.Rotl);

        public void rotl_256x32u()
            => check_op_256<uint>(ShiftKind.Rotl);

        public void rotl_64u()
            => check_op<ulong>(ShiftKind.Rotl);

        public void check_rotl_128x64u()
            => check_op_128<ulong>(ShiftKind.Rotl);

        public void rotl_256x64u()
            => check_op_256<ulong>(ShiftKind.Rotl);

        // ~ rotr

        public void rotr_8u()
            => check_op<byte>(ShiftKind.Rotr);

        public void rotr_128x8u()
            => check_op_128<byte>(ShiftKind.Rotr);

        public void rotr_256x8u()
            => check_op_256<byte>(ShiftKind.Rotr);

        public void rotr_16u()
            => check_op<ushort>(ShiftKind.Rotr);

        public void rotr_128x16u()
            => check_op_128<ushort>(ShiftKind.Rotr);

        public void rotr_256x16u()
            => check_op_256<ushort>(ShiftKind.Rotr);

        public void rotr_32u()
            => check_op<uint>(ShiftKind.Rotr);

        public void rotr_128x32u()
            => check_op_128<uint>(ShiftKind.Rotr);

        public void rotr_256x32u()
            => check_op_256<uint>(ShiftKind.Rotr);

        public void rotr_64u()
            => check_op<ulong>(ShiftKind.Rotr);

        public void rotr_128x64u()
            => check_op_128<ulong>(ShiftKind.Rotr);

        public void check_rotr_256x64u()
            => check_op_256<ulong>(ShiftKind.Rotr);

        void check_op<T>(ShiftKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            byte offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);   
                T actual = LogicEngine.eval(expr);
                T expect = NumericOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(ShiftKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            byte offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n256);
                v1.Set(a);   
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = VectorOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        protected void check_op_128<T>(ShiftKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            byte offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n128);
                v1.Set(a);   
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = VectorOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }
    }
}