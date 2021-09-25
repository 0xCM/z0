//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AsmIdAttribute : Attribute
    {
        public AsmIdAttribute(AsmId id)
        {
            Id = id;
        }

        public AsmId Id {get;}
    }
}
