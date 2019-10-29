//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static TypedLogicSpec;

    public class t_shift_expr : UnitTest<t_shift_expr>
    {

        
       // ~ sll

        public void check_sll_8u()
            => check_op<byte>(ShiftOpKind.Sll);

        public void check_sll_128x8u()
            => check_op_128<byte>(ShiftOpKind.Sll);

        public void check_sll_256x8u()
            => check_op_256<byte>(ShiftOpKind.Sll);

        public void check_sll_32u()
            => check_op<uint>(ShiftOpKind.Sll);

        public void check_sll_128x32u()
            => check_op_128<uint>(ShiftOpKind.Sll);

        public void check_sll_256x32u()
            => check_op_256<uint>(ShiftOpKind.Sll);

        public void check_sll_64u()
            => check_op<ulong>(ShiftOpKind.Sll);

        public void check_sll_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Sll);

        public void check_sll_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Sll);

        // ~ srl

        public void check_srl_8u()
            => check_op<byte>(ShiftOpKind.Srl);

        public void check_srl_128x8u()
            => check_op_128<byte>(ShiftOpKind.Srl);

        public void check_srl_256x8u()
            => check_op_256<byte>(ShiftOpKind.Srl);

        public void check_srl_32u()
            => check_op<uint>(ShiftOpKind.Srl);

        public void check_srl_128x32u()
            => check_op_128<uint>(ShiftOpKind.Srl);

        public void check_srl_256x32u()
            => check_op_256<uint>(ShiftOpKind.Srl);

        public void check_srl_64u()
            => check_op<ulong>(ShiftOpKind.Srl);

        public void check_srl_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Srl);

        public void check_srl_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Srl);

        // ~ rotl

        public void check_rotl_8u()
            => check_op<byte>(ShiftOpKind.Rotl);

        public void check_rotl_128x8u()
            => check_op_128<byte>(ShiftOpKind.Rotl);

        public void check_rotl_256x8u()
            => check_op_256<byte>(ShiftOpKind.Rotl);

        public void check_rotl_32u()
            => check_op<uint>(ShiftOpKind.Rotl);

        public void check_rotl_128x32u()
            => check_op_128<uint>(ShiftOpKind.Rotl);

        public void check_rotl_256x32u()
            => check_op_256<uint>(ShiftOpKind.Rotl);

        public void check_rotl_64u()
            => check_op<ulong>(ShiftOpKind.Rotl);

        public void check_rotl_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Rotl);

        public void check_rotl_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Rotl);

        // ~ rotr

        public void check_rotr_8u()
            => check_op<byte>(ShiftOpKind.Rotr);

        public void check_rotr_128x8u()
            => check_op_128<byte>(ShiftOpKind.Rotr);

        public void check_rotr_256x8u()
            => check_op_256<byte>(ShiftOpKind.Rotr);

        public void check_rotr_16u()
            => check_op<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_128x16u()
            => check_op_128<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_256x16u()
            => check_op_256<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_32u()
            => check_op<uint>(ShiftOpKind.Rotr);

        public void check_rotr_128x32u()
            => check_op_128<uint>(ShiftOpKind.Rotr);

        public void check_rotr_256x32u()
            => check_op_256<uint>(ShiftOpKind.Rotr);

        public void check_rotr_64u()
            => check_op<ulong>(ShiftOpKind.Rotr);

        public void check_rotr_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Rotr);

        public void check_rotr_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Rotr);

 
       void check_op<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);   
                T actual = LogicEngine.eval(expr);
                T expect = ScalarOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_128<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector128<T>();
                v1.Set(a);   
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = CpuOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            var offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector256<T>();
                v1.Set(a);   
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = CpuOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }


    }
}