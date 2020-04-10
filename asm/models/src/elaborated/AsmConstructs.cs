//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    [ApiHost]
    static class Constructs
    {
        [Op]
        public static void for_min_max(int i0, int i1, Action<int> f)
        {
            for(var i=i0; i<i1; i++)
                f(i);
        }

        [Op]
        public static int for_min_max()
        {
            var sum = 0;
            for_min_max(0,8, i => sum += i*i);
            return sum;
        }

        [Op, NumericClosures(NumericKind.All)]
        public static Span<T> alloc<T>(int len)
            => new T[len];

        [Op, NumericClosures(NumericKind.All)]
        public static Type type<T>()
            => typeof(Type);

        [Op]
        public static uint compute_32u(BinaryBitLogicKind op, uint a, uint b)            
            => op switch {
                BinaryBitLogicKind.False => zero<uint>(),
                BinaryBitLogicKind.And => a & b,
                //BinaryBitLogicKind.CNonImpl => math.cnonimpl(a,b),
                BinaryBitLogicKind.LProject => a,
                //BinaryBitLogicKind.NonImpl => math.nonimpl(a,b),   
                BinaryBitLogicKind.RProject => b,
                BinaryBitLogicKind.Xor => a ^ b,
                BinaryBitLogicKind.Or => a | b,
                BinaryBitLogicKind.Nor => ~(a | b),
                BinaryBitLogicKind.Xnor => ~(a ^ b),
                BinaryBitLogicKind.RNot => ~b,
                //BinaryBitLogicKind.Impl => math.impl(a,b),                
                BinaryBitLogicKind.LNot => ~a,
                //BinaryBitLogicKind.CImpl => math.cimpl(a,b),
                BinaryBitLogicKind.Nand => ~(a & b),
                BinaryBitLogicKind.True => Literals.ones<uint>(),
                _ => 0
            };
    }
}