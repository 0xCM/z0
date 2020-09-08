//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public struct AsmRegOp
    {
        public RegisterKind Base;

        public MemScale Scale;

        public MemDx Dx;
    }
}