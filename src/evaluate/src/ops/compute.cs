//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Evaluate
    {
        public static ref readonly UnaryEvaluations<T> compute<T>(in UnaryEvalContext<T> exchange, Action<Exception> error)
            where T : unmanaged
        {
            @try(exchange, error);
            return ref exchange.Target;         
        }
        
        public static ref readonly BinaryEvaluations<T> compute<T>(in BinaryEvalContext<T> exchange, Action<Exception> error)
            where T : unmanaged
        {    
            @try(exchange, error);
            return ref exchange.Target;         
        }    
    }
}