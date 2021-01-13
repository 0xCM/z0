//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.Asci, true)]
    public readonly partial struct asci
    {
        static AsciSymbols AsciStrings => default;

        [MethodImpl(Inline)]
        static bool IndexFound(int i)
            => i != NotFound;

        [MethodImpl(Inline)]
        static int IndexLength(int i, int max)
            => IndexFound(i) ? i : max;
    }
}