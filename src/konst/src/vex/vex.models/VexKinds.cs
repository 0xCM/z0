//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Root;

    [ApiHost]
    public partial class VK
    {
        const NumericKind Closure = AllNumeric;

        /// <summary>
        /// Specifies the 512-bit vector type classifier
        /// </summary>
        public static Vec512Type v512
            => default;

        /// <summary>
        /// Reifies a cell-parametric 512-bit vector kind
        /// </summary>
        public static Vec512Kind<T> vk512<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Closed vector types of width 128
        /// </summary>
        [Op]
        public static ReadOnlySpan<Type> Types128()
            => (from nt in NumericKinds.NumericTypes() select typeof(Vector128<>).MakeGenericType(nt)).Array();

        /// <summary>
        /// Closed vector types of width 256
        /// </summary>
        [Op]
        public static ReadOnlySpan<Type> Types256()
            => (from nt in NumericKinds.NumericTypes() select typeof(Vector256<>).MakeGenericType(nt)).Array();

        /// <summary>
        /// Closed vector types of width 512
        /// </summary>
        [Op]
        public static ReadOnlySpan<Type> Types512()
            => (from nt in NumericKinds.NumericTypes() select typeof(Vector512<>).MakeGenericType(nt)).Array();
    }
}