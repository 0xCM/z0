//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static ReflectionFlags;

    partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static MethodInfo[] methods(Type src)
            => src.GetMethods(BF_All);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MethodView> vMethods(Type src)
            => View(methods(src), method);
    }

    partial struct ClrQuery
    {
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static Index<MethodInfo> methods(Type src)
            => src.GetMethods(BF);
    }
}