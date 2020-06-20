//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static Widths;

    partial class VectorType
    {
        public static IEnumerable<Type> types(W128 w)
            => from nt in NumericKinds.NumericTypes select typeof(Vector128<>).MakeGenericType(nt);

        public static IEnumerable<Type> types(W256 w)
            => from nt in NumericKinds.NumericTypes select typeof(Vector256<>).MakeGenericType(nt);

        public static IEnumerable<Type> types(W512 w)
            => from nt in NumericKinds.NumericTypes select typeof(Vector512<>).MakeGenericType(nt);
    }
}