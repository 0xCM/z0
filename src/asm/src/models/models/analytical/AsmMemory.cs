//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct AsmAddress
    {
        public RegisterKind Base;

        public RegisterKind Seg;

        public MemScale Scale;

        public RegisterKind Prefix;
    }

}