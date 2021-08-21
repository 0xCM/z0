//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct MC
    {
        public class AsmIdAttribute : Attribute
        {
            public AsmIdAttribute(McAsmId id)
            {
                Id = id;
            }

            public McAsmId Id {get;}
        }
    }
}