//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe char* pchar(string src)
            => memory.pchar(src);

        [MethodImpl(Inline)]
        public static unsafe char* pchar2(string src)
            => memory.pchar2(src);
    }
}