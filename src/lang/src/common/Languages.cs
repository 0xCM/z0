//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Languages
    {
        public static Language csharp => nameof(csharp);

        public static Language asm => nameof(asm);

        public static Language cpp => nameof(cpp);

        public static Language typescript => nameof(typescript);
    }
}