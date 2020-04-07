//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using NK = NumericKinds;
    
    partial class XTend
    {
        /// <summary>
        /// Specifies the C# keyword used to designate a kind-identified primal type
        /// </summary>
        public static string Keyword(this NumericKind k)
            => NK.keyword(k);
    }
}