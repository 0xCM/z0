//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    partial class Kinds
    {
        public static OperatorClass Operator 
            => default;

        public static EmitterOpClass EmitterOp
            => default;

        public static UnaryOpClass UnaryOp 
            => default;

        public static BinaryOpClass BinaryOp 
            => default;

        public static TernaryOpClass TernaryOp 
            => default;

        public static ShiftOpClass ShiftOp 
            => default;

        public static EmitterOpClass<T> emitter<T>(T t = default) 
            where T : unmanaged => default;

        public static UnaryOpClass<T> unaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static BinaryOpClass<T> binaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static TernaryOpClass<T> ternaryop<T>(T t = default)  
            where T : unmanaged => default;
    }
}