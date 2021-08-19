//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct SymbolicRender
    {
        [MethodImpl(Inline), Op]
        public static uint crlf(ref uint i, Span<char> dst)
        {
            var i0 = i;
            seek(dst,i++) = (char)AsciControlSym.CR;
            seek(dst,i++) = (char)AsciControlSym.LF;
            return i - i0;
        }
    }
}