//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Classes;

    public static partial class ClassReps
    {
        public static Receiver Receiver => default;

        public static UnaryAction UnaryAction => default;

        public static BinaryAction BinaryAction => default;

        public static TernaryAction TernaryAction => default;

        public static Receiver receiver() => default; 

        public static UnaryAction action(Unary rep) =>  default;

        public static BinaryAction action(Binary rep) =>  default;

        public static TernaryAction action(Ternary rep) =>  default;

        public static Receiver<T> receiver<T>() where T : unmanaged => default;

        public static UnaryAction<T> action<T>(Unary<T> rep) where T : unmanaged =>  default;

        public static BinaryAction<T> action<T>(Binary<T> rep) where T : unmanaged =>  default;

        public static TernaryAction<T> action<T>(Ternary<T> rep) where T : unmanaged =>  default;
    }
}