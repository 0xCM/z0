//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = Kinds;

    partial class Kinds
    {            
        public static K.EmitterFunc func(A0 rep) 
            => default;

        public static K.UnaryFunc func(A1 rep) 
            => default;

        public static K.BinaryFunc func(A2 rep) 
            => default;

        public static K.TernaryFunc func(A3 rep) 
            => default;

        public static K.EmitterFunc<T> func<T>(A0<T> rep) 
            where T : unmanaged =>  default;

        public static K.UnaryFunc<T> func<T>(A1<T> rep) 
            where T : unmanaged =>  default;

        public static K.BinaryFunc<T> func<T>(A2<T> rep) 
            where T : unmanaged => default;

        public static K.TernaryFunc<T> func<T>(A3<T> rep) 
            where T : unmanaged => default;

        public static K.UnaryFunc<T> func<T>(A1 rep) 
            where T : unmanaged =>  default;

        public static K.BinaryFunc<T> func<T>(A2 rep) 
            where T : unmanaged => default;

        public static K.TernaryFunc<T> func<T>(A3 rep) 
            where T : unmanaged => default;

        public static K.UnaryFunc<A,R> func<A,R>(A a = default, R r = default) 
            => default;

        public static K.BinaryFunc<A,B,R> func<A,B,R>(A a = default, B b = default, R r = default) 
            => default;

        public static K.TernaryFunc<A,B,C,R> func<A,B,C,R>(A a = default, B b = default, C c = default, R r = default) 
            => default;
    }

    partial class XTend
    {
        public static K.UnaryFunc<A,R> As<A,R>(this K.UnaryFunc f, 
            A a = default, R r = default) => default;

        public static K.BinaryFunc<A,B,R> As<A,B,R>(this K.BinaryFunc f, 
            A a = default, B b = default, R r = default)  => default;

        public static K.TernaryFunc<A,B,C,R> As<A,B,C,R>(this K.TernaryFunc f, 
            A a = default, B b = default, C c = default,  R r = default)  => default;        
    }
}