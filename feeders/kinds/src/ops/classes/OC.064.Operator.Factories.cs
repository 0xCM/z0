//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using C = OpClass;

    partial class OpReps
    {
        public static C.OperatorClass Operator => default;

        public static C.UnaryOp UnaryOp => default;

        public static C.BinaryOp BinaryOp => default;

        public static C.TernaryOp TernaryOp => default;

        public static C.OperatorClass oper8or() => default;

        public static C.UnaryOp oper8or(C.Unary rep) => default;

        public static C.BinaryOp oper8or(C.Binary rep) => default;

        public static C.TernaryOp oper8or(C.Ternary rep) => default;

        public static C.OperatorClass<T> oper8or<T>() where T : unmanaged => default;

        public static C.UnaryOp<T> oper8or<T>(C.Unary<T> rep)  where T : unmanaged => default;

        public static C.BinaryOp<T> oper8or<T>(C.Binary<T> rep)  where T : unmanaged => default;

        public static C.TernaryOp<T> oper8or<T>(C.Ternary<T> rep)  where T : unmanaged => default;

        public static C.OperatorClass<T> As<T>(this C.OperatorClass src) where T : unmanaged => default;

        public static C.UnaryOp<T> As<T>(this C.UnaryOp src) where T : unmanaged => default;
        
        public static C.BinaryOp<T> As<T>(this C.BinaryOp src)  where T : unmanaged => default;

        public static C.TernaryOp<T> As<T>(this C.TernaryOp src) where T : unmanaged => default;
    }
}