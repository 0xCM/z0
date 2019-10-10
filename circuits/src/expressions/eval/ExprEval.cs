//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Bitwise
    {


        public static class LiteralEval
        {
            [MethodImpl(Inline)]
            public static IBitwiseExprEval<T,LiteralExpr<T>> scalar<T>()
                where T : unmanaged
                    => LiteralScalarExprEval<T>.TheOnly;            

            [MethodImpl(Inline)]
            public static IBitwiseExprEval<T, LiteralExpr<Vec128<T>>> vec128<T>()
                where T : unmanaged
                    => LiteralVec128ExprEval<T>.TheOnly;

            [MethodImpl(Inline)]
            public static IBitwiseExprEval<T, LiteralExpr<Vec256<T>>> vec256<T>()
                where T : unmanaged
                    => LiteralVec256ExprEval<T>.TheOnly;

        }

    }

}