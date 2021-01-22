//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using static Part;

    partial class XWf
    {
        public static Task Continue<T>(this Task<T> src, Action<T> @continue)
            where T : struct, ICmd
                => src.ContinueWith(t => @continue(t.Result));
    }
}