//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;


    public static class KindExtensions
    {
       [MethodImpl(Inline)]
        public static TernaryOpKind Next(this TernaryOpKind src)
            => src != TernaryOpKind.XFF 
                ? (TernaryOpKind)((uint)(src) + 1u)
                : TernaryOpKind.X00;
        
        [MethodImpl(Inline)]
        public static bool IsOperator(this LogicExprKind kind)
            => (uint)kind >= (uint)LogicExprKind.UnaryOperator;

        [MethodImpl(Inline)]
        public static bool IsOperator(this TypedExprKind kind)
            => (uint)kind >= (uint)TypedExprKind.UnaryOperator;

        [MethodImpl(Inline)]
        public static BinaryLogicOpKind ToLogical(this BinaryBitwiseOpKind kind)
            => (BinaryLogicOpKind)kind;

        [MethodImpl(Inline)]
        public static BinaryBitwiseOpKind ToBitwise(this BinaryLogicOpKind kind)
            => (BinaryBitwiseOpKind)kind;

    }

}