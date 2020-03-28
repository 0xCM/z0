//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using C = OpClass;

    partial class OpClasses
    {
        public static C.OperatorClass Operator 
            => default;

        public static C.UnaryOp UnaryOp 
            => default;

        public static C.BinaryOp BinaryOp 
            => default;

        public static C.TernaryOp TernaryOp 
            => default;

        public static C.OperatorClass oper8or() 
            => default;

        public static C.UnaryOp unaryop() 
            => default;

        public static C.BinaryOp binaryop() 
            => default;

        public static C.TernaryOp ternaryop() 
            => default;

        public static C.OperatorClass<T> oper8or<T>(T t = default) 
            where T : unmanaged => default;

        public static C.UnaryOp<T> unaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static C.BinaryOp<T> binaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static C.TernaryOp<T> ternaryop<T>(T t = default)  
            where T : unmanaged => default;

        public static C.OperatorClass<T> As<T>(this C.OperatorClass src) 
            where T : unmanaged => default;

        public static C.UnaryOp<T> As<T>(this C.UnaryOp src) 
            where T : unmanaged => default;
        
        public static C.BinaryOp<T> As<T>(this C.BinaryOp src)
             where T : unmanaged => default;

        public static C.TernaryOp<T> As<T>(this C.TernaryOp src) 
            where T : unmanaged => default;
    }
}