//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    partial class Kinds
    {
        public static And<T> and<T>() => default(And<T>);

        public static Nand<T> nand<T>() => default(Nand<T>);

        public static Or<T> or<T>() => default(Or<T>);

        public static Nor<T> nor<T>() => default(Nor<T>);
    }
}