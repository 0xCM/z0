//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    partial class Classified
    {
        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool blocked(MethodInfo m)
            => m.ReturnType.IsDataBlock() || m.ParameterTypes().Any(t => t.IsDataBlock());

        /// <summary>
        /// Enumerates the blocked data types
        /// </summary>
        public static IEnumerable<Type> BlockTypes
            => items(typeof(Block16<>), typeof(Block32<>), typeof(Block64<>), typeof(Block128<>), typeof(Block256<>), typeof(Block512<>));

        /// <summary>
        /// Enumerates the blocked data type names
        /// </summary>
        public static IEnumerable<string> BlockTypeNames
            => items("Block16", "Block32", "Block64", "Block128", "Block256", "Block512");

        /// <summary>
        /// Determines whether a type is a data block of some sort
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool blocked(Type t)
            => BlockTypeNames.Where(n => t.Name.StartsWith(n)).Any();
    }
}