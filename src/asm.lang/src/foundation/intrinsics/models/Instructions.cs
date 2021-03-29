//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial class IntelIntrinsics
    {
        public class Instructions : List<Instruction>, ITextual
        {
            public string Format()
            {
                var count = Count;
                if(count != 0)
                {
                    var dst = text.buffer();
                    root.iter(this, x => dst.AppendLineFormat("# {0}",x));
                    return dst.Emit();
                }
                else
                    return EmptyString;
            }

            public override string ToString()
                => Format();
        }
    }
}