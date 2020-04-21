//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    public partial class XQuery
    { 
        [MethodImpl(Inline)]
        static T cast<T>(object src)
            => (T)src;
    }
}