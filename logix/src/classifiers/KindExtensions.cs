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
        public static TernaryBitOpKind Next(this TernaryBitOpKind src)
            => src != TernaryBitOpKind.XFF 
                ? (TernaryBitOpKind)((uint)(src) + 1u)
                : TernaryBitOpKind.X00;
        
        [MethodImpl(Inline)]
        public static bool IsOperator(this LogicExprKind kind)
            => (uint)kind >= (uint)LogicExprKind.UnaryOperator;

        [MethodImpl(Inline)]
        public static bool IsOperator(this TypedExprKind kind)
            => (uint)kind >= (uint)TypedExprKind.UnaryOperator;

    }

}