//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    partial class Kinds
    {
        public static And and() => default(And);

        public static Nand nand() => default(Nand);

        public static Or or() => default(Or);

        public static Nor nor() => default(Nor);

        public static Xor xor() => default(Xor);

        public static Xnor xnor() => default(Xnor);

        public static LNot lnot() => default(LNot);

        public static RNot rnot() => default(RNot);
        
        public static And<T> and<T>() => default(And<T>);

        public static Nand<T> nand<T>() => default(Nand<T>);

        public static Or<T> or<T>() => default(Or<T>);

        public static Nor<T> nor<T>() => default(Nor<T>);
    }
}