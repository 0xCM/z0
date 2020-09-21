//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Linq;

    [ApiHost("kinds.vectors")]
    public partial class VectorKinds
    {
        /// <summary>
        /// Closed vector types of width 128
        /// </summary>
        public static ReadOnlySpan<Type> Types128
            => (from nt in NumericKinds.NumericTypes select typeof(Vector128<>).MakeGenericType(nt)).Array();

        /// <summary>
        /// Closed vector types of width 256
        /// </summary>
        public static ReadOnlySpan<Type> Types256
            => (from nt in NumericKinds.NumericTypes select typeof(Vector256<>).MakeGenericType(nt)).Array();

        /// <summary>
        /// Closed vector types of width 512
        /// </summary>
        public static ReadOnlySpan<Type> Types512
            => (from nt in NumericKinds.NumericTypes select typeof(Vector512<>).MakeGenericType(nt)).Array();
    }
}