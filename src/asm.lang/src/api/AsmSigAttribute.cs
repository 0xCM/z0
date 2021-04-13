//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class AsmSigAttribute : Attribute
    {
        public AsmSigAttribute(AsmOc kind)
        {
            Kind = kind;
        }

        public AsmOc Kind {get;}
    }
}