//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using K = Kinds;

    partial class Kinds
    {
        public static K.OperatorClass Operator 
            => default;

        public static K.EmitterOpClass EmitterOp
            => default;

        public static K.UnaryOpClass UnaryOp 
            => default;

        public static K.BinaryOpClass BinaryOp 
            => default;

        public static K.TernaryOpClass TernaryOp 
            => default;

        public static K.ShiftOpClass ShiftOp 
            => default;

        public static K.EmitterOpClass<T> emitter<T>(T t = default) 
            where T : unmanaged => default;

        public static K.UnaryOpClass<T> unaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static K.BinaryOpClass<T> binaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static K.TernaryOpClass<T> ternaryop<T>(T t = default)  
            where T : unmanaged => default;
    }
}