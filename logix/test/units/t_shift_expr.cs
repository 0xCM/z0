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
            => check_op<byte>(ShiftOpKindId.Sll);

        public void sll_128x8u()
            => check_op_128<byte>(ShiftOpKindId.Sll);

        public void sll_256x8u()
            => check_op_256<byte>(ShiftOpKindId.Sll);

        public void sll_32u()
            => check_op<uint>(ShiftOpKindId.Sll);

        public void sll_128x32u()
            => check_op_128<uint>(ShiftOpKindId.Sll);

        public void sll_256x32u()
            => check_op_256<uint>(ShiftOpKindId.Sll);

        public void sll_64u()
            => check_op<ulong>(ShiftOpKindId.Sll);

        public void sll_128x64u()
            => check_op_128<ulong>(ShiftOpKindId.Sll);

        public void sll_256x64u()
            => check_op_256<ulong>(ShiftOpKindId.Sll);

        // ~ srl

        public void srl_8u()
            => check_op<byte>(ShiftOpKindId.Srl);

        public void srl_128x8u()
            => check_op_128<byte>(ShiftOpKindId.Srl);

        public void srl_256x8u()
            => check_op_256<byte>(ShiftOpKindId.Srl);

        public void check_srl_32u()
            => check_op<uint>(ShiftOpKindId.Srl);

        public void srl_128x32u()
            => check_op_128<uint>(ShiftOpKindId.Srl);

        public void srl_256x32u()
            => check_op_256<uint>(ShiftOpKindId.Srl);

        public void check_srl_64u()
            => check_op<ulong>(ShiftOpKindId.Srl);

        public void srl_128x64u()
            => check_op_128<ulong>(ShiftOpKindId.Srl);

        public void srl_256x64u()
            => check_op_256<ulong>(ShiftOpKindId.Srl);

        // ~ rotl

        public void rotl_8u()
            => check_op<byte>(ShiftOpKindId.Rotl);

        public void rotl_128x8u()
            => check_op_128<byte>(ShiftOpKindId.Rotl);

        public void rotl_256x8u()
            => check_op_256<byte>(ShiftOpKindId.Rotl);

        public void rotl_32u()
            => check_op<uint>(ShiftOpKindId.Rotl);

        public void rotl_128x32u()
            => check_op_128<uint>(ShiftOpKindId.Rotl);

        public void rotl_256x32u()
            => check_op_256<uint>(ShiftOpKindId.Rotl);

        public void rotl_64u()
            => check_op<ulong>(ShiftOpKindId.Rotl);

        public void check_rotl_128x64u()
            => check_op_128<ulong>(ShiftOpKindId.Rotl);

        public void rotl_256x64u()
            => check_op_256<ulong>(ShiftOpKindId.Rotl);

        // ~ rotr

        public void rotr_8u()
            => check_op<byte>(ShiftOpKindId.Rotr);

        public void rotr_128x8u()
            => check_op_128<byte>(ShiftOpKindId.Rotr);

        public void rotr_256x8u()
            => check_op_256<byte>(ShiftOpKindId.Rotr);

        public void rotr_16u()
            => check_op<ushort>(ShiftOpKindId.Rotr);

        public void rotr_128x16u()
            => check_op_128<ushort>(ShiftOpKindId.Rotr);

        public void rotr_256x16u()
            => check_op_256<ushort>(ShiftOpKindId.Rotr);

        public void rotr_32u()
            => check_op<uint>(ShiftOpKindId.Rotr);

        public void rotr_128x32u()
            => check_op_128<uint>(ShiftOpKindId.Rotr);

        public void rotr_256x32u()
            => check_op_256<uint>(ShiftOpKindId.Rotr);

        public void rotr_64u()
            => check_op<ulong>(ShiftOpKindId.Rotr);

        public void rotr_128x64u()
            => check_op_128<ulong>(ShiftOpKindId.Rotr);

        public void check_rotr_256x64u()
            => check_op_256<ulong>(ShiftOpKindId.Rotr);

        void check_op<T>(ShiftOpKindId op)
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

        void check_op_256<T>(ShiftOpKindId op)
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

        protected void check_op_128<T>(ShiftOpKindId op)
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