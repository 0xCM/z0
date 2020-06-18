//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        
        [MethodImpl(Inline)]
        public static string Format<K>(this K kind)
            where K : IOpKind   
                => kind.Format();
    }
}