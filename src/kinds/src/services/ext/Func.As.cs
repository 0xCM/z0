//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = Kinds;

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