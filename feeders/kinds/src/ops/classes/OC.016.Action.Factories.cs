//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    using static OpClass;

    public static partial class OpClasses
    {
        public static Receiver Receiver => default;

        public static UnaryAction UnaryAction => default;

        public static BinaryAction BinaryAction => default;

        public static TernaryAction TernaryAction => default;

        public static UnaryAction action(A1 rep) 
            => default;

        public static BinaryAction action(A2 rep) 
            => default;

        public static TernaryAction action(A3 rep) 
            => default;

        public static Receiver<T> receiver<T>() 
            where T : unmanaged => default;

        public static UnaryAction<T> action<T>(A1<T> rep) 
            where T : unmanaged =>  default;

        public static BinaryAction<T> action<T>(A2<T> rep) 
            where T : unmanaged =>  default;

        public static TernaryAction<T> action<T>(A3<T> rep)    
            where T : unmanaged =>  default;
    }
}