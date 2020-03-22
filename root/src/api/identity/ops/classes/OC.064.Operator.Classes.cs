//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = OperatorClass;
    
    partial class Classes
    {
        public readonly struct OperatorClass : IOpClass<C> { public C Class => C.Operator; } 
        
        public readonly struct UnaryOp : IOpClass<C> { public C Class => C.UnaryOp; }

        public readonly struct BinaryOp : IOpClass<C> { public C Class => C.BinaryOp; }

        public readonly struct TernaryOp : IOpClass<C> { public C Class => C.TernaryOp; }

        public readonly struct OperatorClass<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.Operator; }

        public readonly struct UnaryOp<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.UnaryOp; }

        public readonly struct BinaryOp<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.BinaryOp; }

        public readonly struct TernaryOp<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.TernaryOp; }
    }
}