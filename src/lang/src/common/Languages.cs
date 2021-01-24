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
        public static LanguageSpec csharp => nameof(csharp);

        public static LanguageSpec asm => nameof(asm);

        public static LanguageSpec cpp => nameof(cpp);

        public static LanguageSpec typescript => nameof(typescript);
    }
}