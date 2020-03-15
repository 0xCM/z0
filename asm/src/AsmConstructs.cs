//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost("constructs")]
    public static class AsmConstructs
    {

        [MethodImpl(NotInline), Op]
        public static void for_min_max(int i0, int i1, Action<int> f)
        {
            for(var i=i0; i<i1; i++)
                f(i);
        }

        [MethodImpl(NotInline), Op]
        public static int for_min_max()
        {
            var sum = 0;
            for_min_max(0,8, i => sum += i*i);
            return sum;
        }

        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        public static Span<T> alloc<T>(int len)
            => new T[len];

        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        public static Type type<T>()
            => typeof(Type);


        [MethodImpl(NotInline), Op]
        public static uint compute_32u(BinaryBitLogicOpKind op, uint a, uint b)            
            => op switch {
                BinaryBitLogicOpKind.False => zero<uint>(),
                BinaryBitLogicOpKind.And => math.and(a,b),
                BinaryBitLogicOpKind.CNonImpl => math.cnonimpl(a,b),
                BinaryBitLogicOpKind.LProject => a,
                BinaryBitLogicOpKind.NonImpl => math.nonimpl(a,b),   
                BinaryBitLogicOpKind.RProject => b,
                BinaryBitLogicOpKind.Xor => math.xor(a,b),
                BinaryBitLogicOpKind.Or => math.or(a,b),
                BinaryBitLogicOpKind.Nor => math.nor(a,b),
                BinaryBitLogicOpKind.Xnor => math.xnor(a,b),
                BinaryBitLogicOpKind.RNot => math.not(b),
                BinaryBitLogicOpKind.Impl => math.impl(a,b),                
                BinaryBitLogicOpKind.LNot => math.not(a),
                BinaryBitLogicOpKind.CImpl => math.cimpl(a,b),
                BinaryBitLogicOpKind.Nand => math.nand(a,b),
                BinaryBitLogicOpKind.True => ones<uint>(),
                _ => 0
            };
    }
}