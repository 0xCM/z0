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

    partial struct IntelIntrinsicsModel
    {
        public struct Operation : ITextual
        {
            public const string ElementName = "operation";

            public List<TextLine> Content;

            [MethodImpl(Inline)]
            public Operation(List<TextLine> src)
            {
                Content = src;
            }

            public override string ToString()
                => Format();

            public string Format()
            {
                if(Content != null)
                {
                    var dst = text.buffer();
                    foreach(var line in Content)
                        dst.AppendLine(line);
                    return dst.Emit();
                }
                else
                    return EmptyString;
            }
        }
    }
}