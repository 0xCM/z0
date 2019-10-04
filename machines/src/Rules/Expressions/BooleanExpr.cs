//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;


    public interface IBooleanExprEval<T>
        where T : unmanaged
    {
        BooleanBinaryExpr<T> And(BooleanBinaryExpr<T> a, BooleanBinaryExpr<T> b);

        BooleanBinaryExpr<T> Or(BooleanBinaryExpr<T> a, BooleanBinaryExpr<T> b);

        BooleanBinaryExpr<T> XOr(BooleanBinaryExpr<T> a, BooleanBinaryExpr<T> b);

        BooleanBinaryExpr<T> Not(BooleanBinaryExpr<T> a);    

        bool Test(BooleanBinaryExpr<T> a, T value);       
    }

    public enum BooleanOpKind
    {
        And,

        Or,

        XOr,

        Not,
    }

    public readonly struct BooleanBinaryExpr<T> : IRuleExpr
        where T : unmanaged
    {
        public static BooleanBinaryExpr<T> operator  &(BooleanBinaryExpr<T> a, BooleanBinaryExpr<T> b)  
            => default;

        public static BooleanBinaryExpr<T> operator  |(BooleanBinaryExpr<T> a, BooleanBinaryExpr<T> b)  
            => default;

        public static BooleanBinaryExpr<T> operator  ^(BooleanBinaryExpr<T> a, BooleanBinaryExpr<T> b)  
            => default;

        

    }

}