//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial class XQuery
    {
        [MethodImpl(Inline)]
        static T cast<T>(object src)
            => (T)src;
    }
}