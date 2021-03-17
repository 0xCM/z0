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
        public class Parameters : List<Parameter>
        {
            const string Delimiter = ", ";

            public string Format()
            {
                var count = Count;
                if(count != 0)
                    return TextRules.Format.join(Delimiter, this);
                else
                    return EmptyString;
            }

            public override string ToString()
                => Format();
        }
    }
}