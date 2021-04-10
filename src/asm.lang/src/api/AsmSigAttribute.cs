//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class AsmSigAttribute : Attribute
    {
        public AsmSigAttribute(AsmSigKind kind)
        {
            Kind = kind;
        }

        public AsmSigKind Kind {get;}
    }
}