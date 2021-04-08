//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
        public static string format(NasmSource src)
        {
            var dst = text.buffer();
            var expressions = src.Expressions.View;
            var count = expressions.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(expressions,i));
            return dst.Emit();
        }
    }
}