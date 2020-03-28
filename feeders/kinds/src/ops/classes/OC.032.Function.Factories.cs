//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static OpClass;

    using C = OpClass;

    partial class OpClasses
    {
        public static C.Emitter Emitter 
            => default;

        public static C.UnaryFunc UnaryFunc 
            => default;

        public static C.BinaryFunc BinaryFunc 
            => default;

        public static C.TernaryFunc TernaryFunc 
            => default;
            
        public static C.Emitter func(A0 rep) 
            => default;

        public static C.UnaryFunc func(A1 rep) 
            => default;

        public static C.BinaryFunc func(A2 rep) 
            => default;

        public static C.TernaryFunc func(A3 rep) 
            => default;

        public static C.Emitter<T> emitter<T>(T t = default) 
            where T : unmanaged => default;

        public static C.UnaryFunc<T> unaryfunc<T>(T t = default) 
            where T : unmanaged =>  default;

        public static C.BinaryFunc<T> binaryfunc<T>(T t = default) 
            where T : unmanaged => default;

        public static C.TernaryFunc<T> ternaryfunc<T>(T t = default) 
            where T : unmanaged => default;

        public static C.UnaryFunc<T> func<T>(A1<T> rep) 
            where T : unmanaged =>  default;

        public static C.BinaryFunc<T> func<T>(A2<T> rep) 
            where T : unmanaged => default;

        public static C.TernaryFunc<T> func<T>(A3<T> rep) 
            where T : unmanaged => default;

        public static C.UnaryFunc<T> func<T>(A1 rep) 
            where T : unmanaged =>  default;

        public static C.BinaryFunc<T> func<T>(A2 rep) 
            where T : unmanaged => default;

        public static C.TernaryFunc<T> func<T>(A3 rep) 
            where T : unmanaged => default;
    }
}