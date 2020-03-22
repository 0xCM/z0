//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Classes;

    partial class ClassReps
    {
        public static Emitter Emitter => default;

        public static UnaryFunc UnaryFunc => default;

        public static BinaryFunc BinaryFunc => default;

        public static TernaryFunc TernaryFunc => default;

        public static Emitter emitter() => default;

        public static UnaryFunc func(Unary rep) =>  default;

        public static BinaryFunc func(Binary rep) =>  default;

        public static TernaryFunc func(Ternary rep) =>  default;

        public static Emitter<T> emitter<T>() where T : unmanaged => default;

        public static UnaryFunc<T> func<T>(Unary<T> rep) where T : unmanaged =>  default;

        public static BinaryFunc<T> func<T>(Binary<T> rep) where T : unmanaged => default;

        public static TernaryFunc<T> func<T>(Ternary<T> rep) where T : unmanaged => default;
    }
}