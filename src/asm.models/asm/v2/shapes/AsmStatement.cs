//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct AsmStatement<M>
    {
        public M Mnemonic;
    }

    public struct AsmStatement<M,A0>
    {
        public M Mnemonic;

        public A0 Op0;
    }

    public struct AsmStatement<M,A0,A1>
    {
        public M Mnemonic;

        public A0 Op0;

        public A1 Op1;
    }

    public struct AsmStatement<M,A0,A1,A2>
    {
        public M Mnemonic;

        public A0 Op0;

        public A1 Op1;

        public A2 Op2;
    }

    public struct AsmStatement<M,A0,A1,A2,A3>
    {
        public M Mnemonic;

        public A0 Op0;

        public A1 Op1;

        public A2 Op2;

        public A3 Op3;
    }
}