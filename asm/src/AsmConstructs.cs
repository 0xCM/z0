//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static ConstructIdentifier;

    public static class ConstructIdentifier
    {
        public const string Alloc = nameof(Alloc);
    }

    public class ConstructIdAttribute : Attribute
    {
        public ConstructIdAttribute(string id)
        {
            this.Id = id;
        }

        public string Id {get;}

    }

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

        [MethodImpl(NotInline), Op, ConstructId(Alloc)]
        public static Span<uint> alloc_32u(int len)
            => new uint[len];


        [MethodImpl(NotInline), Op]
        public static uint compute_32u(BinaryBitLogicKind op, uint a, uint b)            
            => op switch {
                BinaryBitLogicKind.And => math.and(a,b),
                BinaryBitLogicKind.Or => math.or(a,b),
                BinaryBitLogicKind.Xor => math.xor(a,b),
                BinaryBitLogicKind.Nand => math.nand(a,b),
                BinaryBitLogicKind.Nor => math.nor(a,b),
                BinaryBitLogicKind.Xnor => math.xnor(a,b),
                BinaryBitLogicKind.Impl => math.impl(a,b),                
                BinaryBitLogicKind.NonImpl => math.nonimpl(a,b),   
                BinaryBitLogicKind.CImpl => math.cimpl(a,b),
                BinaryBitLogicKind.CNonImpl => math.cnonimpl(a,b),
                BinaryBitLogicKind.LNot => math.not(a),
                BinaryBitLogicKind.RNot => math.not(b),
                BinaryBitLogicKind.LProject => a,
                BinaryBitLogicKind.RProject => b,
                BinaryBitLogicKind.True => gmath.ones<uint>(),
                BinaryBitLogicKind.False => gmath.zero<uint>(),
                _ => 0
            };
    }

}