//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    using static Kinds;

    partial class Kinded
    {
        public static And And => default(And);

        public static Nand Nand => default(Nand);

        public static Or Or => default(Or);

        public static Nor Nor => default(Nor);

        public static Xor Xor => default(Xor);

        public static Xnor Xnor => default(Xnor);

        public static LNot LNot => default(LNot);

        public static RNot RNot => default(RNot);
    }
}