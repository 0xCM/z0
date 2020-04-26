//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    partial class Kinds
    {
        public static And and() => Kinded.And;

        public static Nand nand() => Kinded.Nand;

        public static Or or() => Kinded.Or;

        public static Nor nor() => Kinded.Nor;

        public static Xor xor() => Kinded.Xor;

        public static Xnor xnor() => Kinded.Xnor;

        public static LNot lnot() => Kinded.LNot;

        public static RNot rnot() => Kinded.RNot;        
    }
}