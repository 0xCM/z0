//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using CC = System.Runtime.InteropServices.CallingConvention;

    [ApiHost]
    public readonly partial struct Root
    {
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));

        /// <summary>
        /// Indicates that emitted content should overwrite whatever file content may exist
        /// </summary>
        public const FileWriteMode Overwrite = FileWriteMode.Overwrite;

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// Specifies the <see cref='CC.StdCall'/> calling convention where the
        /// callee is responsible for stack management
        /// </summary>
        /// <remarks>
        /// This is the default PInvoke convention
        /// </remarks>
        public const CC StdCall = CC.StdCall;

        /// <summary>
        /// Specifies the <see cref='CC.Cdecl'/> calling convention where the caller
        /// is responsible for stack management
        /// </summary>
        /// <remarks>
        /// According to the runtime documentation, "This enables calling functions with varargs, which
        /// makes it appropriate to use for methods that accept a variable number of parameters,
        /// such as Printf".
        /// </remarks>
        public const CC Cdecl = CC.Cdecl;

        /// <summary>
        /// Specifies the <see cref='CC.ThisCall'/> calling convention where first argument is <see cref='this'/>
        /// and is placed in ECX/RCX
        /// </summary>
        public const CC ThisCall = CC.ThisCall;

        [MethodImpl(Inline), Op]
        public static uint hash(PartId src)
            => (uint)src;

        public static T[] array<T>(params T[] src)
            => src;

        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
         [MethodImpl(Inline)]
         public static Y apply<X,Y>(X x, Func<X,Y> f)
            => f(x);


        [MethodImpl(Inline), Op]
        public static string format(ExternId id)
            => id.ToString().ToLower();

        const string TestSuffix = ".test";

        const string SvcSuffix = ".svc";

        const string BaseSuffix = "";

        public const string EmptyString = "";
    }

    [ApiHost]
    public static partial class XTend
    {
        const NumericKind Closure = Root.UnsignedInts;

    }

    [ApiHost]
    public static partial class XText
    {
        const NumericKind Closure = Root.UnsignedInts;

    }

    [ApiHost]
    public static partial class ClrQuery
    {
        const NumericKind Closure = Root.UnsignedInts;

    }
}