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

    public static class SystemTypes
    {
        /// <summary>
        /// Determines whether a type is a non-numeric system primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool nonnumeric(Type src)
            => src.IsBool() || src.IsVoid() || src.IsChar() || src.IsString() || src.IsObject();

        /// <summary>
        /// Determines whether a type is system-defined primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool test(Type src)
            => src.IsNumeric() || nonnumeric(src);
    }
}