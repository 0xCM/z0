//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class AsmSigAttribute : Attribute
    {
        public AsmSigAttribute(string kind)
        {
            Kind = kind;
        }

        public string Kind {get;}

        public AsmSigAttribute(object kind)
        {
            Kind = kind.ToString();
        }
    }
}