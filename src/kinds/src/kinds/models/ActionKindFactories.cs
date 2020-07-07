//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Kinds
    {
        public static UnaryActionClass action(A1 rep) 
            => default;

        public static BinaryActionClass action(A2 rep) 
            => default;

        public static TernaryActionClass action(A3 rep) 
            => default;

        public static ReceiverClass<T> receiver<T>() 
            where T : unmanaged => default;

        public static UnaryActionClass<T> action<T>(A1<T> rep) 
            where T : unmanaged =>  default;

        public static BinaryActionClass<T> action<T>(A2<T> rep) 
            where T : unmanaged =>  default;

        public static TernaryActionClass<T> action<T>(A3<T> rep)    
            where T : unmanaged =>  default;
    }
}