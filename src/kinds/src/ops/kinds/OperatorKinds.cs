//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using C = Kinds;

    partial class Kinds
    {
        public static C.OperatorClass Operator 
            => default;

        public static C.UnaryOpClass UnaryOp 
            => default;

        public static C.BinaryOpClass BinaryOp 
            => default;

        public static C.TernaryOpClass TernaryOp 
            => default;

        public static C.UnaryOpClass<T> unaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static C.BinaryOpClass<T> binaryop<T>(T t = default) 
            where T : unmanaged => default;

        public static C.TernaryOpClass<T> ternaryop<T>(T t = default)  
            where T : unmanaged => default;

        public static C.OperatorClass<T> As<T>(this C.OperatorClass src) 
            where T : unmanaged => default;

        public static C.UnaryOpClass<T> As<T>(this C.UnaryOpClass src) 
            where T : unmanaged => default;
        
        public static C.BinaryOpClass<T> As<T>(this C.BinaryOpClass src)
             where T : unmanaged => default;

        public static C.TernaryOpClass<T> As<T>(this C.TernaryOpClass src) 
            where T : unmanaged => default;

        public static C.OperatorClass<W> Fixed<W>(this C.OperatorClass src) 
            where W : unmanaged, ITypeWidth => default;

        public static C.UnaryOpClass<W> Fixed<W>(this C.UnaryOpClass src)
            where W : unmanaged, ITypeWidth => default;

        public static C.BinaryOpClass<W> Fixed<W>(this C.BinaryOpClass src)
            where W : unmanaged, ITypeWidth => default;

        public static C.TernaryOpClass<W> Fixed<W>(this C.TernaryOpClass src)
            where W : unmanaged, ITypeWidth => default;
    }
}