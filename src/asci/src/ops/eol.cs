//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsciControlCode;

    using CC = AsciControlCode;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static bit eol(byte a0, byte a1)
            => (CC)a0 == CR || (CC)a1 == LF;
    }
}