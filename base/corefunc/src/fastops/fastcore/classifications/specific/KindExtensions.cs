//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;


    public static class KindExtensions
    {
       [MethodImpl(Inline)]
        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF 
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00;
        
        [MethodImpl(Inline)]
        public static bool IsOperator(this LogicExprKind kind)
            => (uint)kind >= (uint)LogicExprKind.UnaryOperator;

        [MethodImpl(Inline)]
        public static bool IsOperator(this TypedExprKind kind)
            => (uint)kind >= (uint)TypedExprKind.UnaryOperator;

        [MethodImpl(Inline)]
        public static BinaryBitLogicKind ToLogical(this BinaryBitwiseOpKind kind)
            => (BinaryBitLogicKind)kind;

        [MethodImpl(Inline)]
        public static BinaryBitwiseOpKind ToBitwise(this BinaryBitLogicKind kind)
            => (BinaryBitwiseOpKind)kind;

    }

}