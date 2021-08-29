//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static core;

    partial class AsmCmdService
    {
        void Write<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths)
            where T : struct
        {
            var formatter = Tables.formatter<T>(widths);
            var count = src.Length;
            for(var i=0; i<count; i++)
                Write(formatter.Format(skip(src,i)));
        }
    }
}