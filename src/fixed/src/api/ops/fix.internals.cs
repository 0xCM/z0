//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;

    using static Seed;

    using K = Kinds;

    partial class Fixed
    {        
        [MethodImpl(Inline)]
        static UnaryOp<T> create<T>(MethodInfo src, K.UnaryOpClass<T> k)
            where T : unmanaged
                => Delegates.unary<T>(src);

        [MethodImpl(Inline)]
        static BinaryOp<T> create<T>(MethodInfo src, K.BinaryOpClass<T> K)
            where T : unmanaged
                => Delegates.binary<T>(src);
    }
}