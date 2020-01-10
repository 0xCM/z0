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
            => m.ReturnType.IsBlocked() || m.ParameterTypes().Any(t => t.IsBlocked());        

        /// <summary>
        /// If the source type is primal, intrinsic, or blocked, returns the bit-width; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int blockwidth(Type t)
        {

            if(t.IsBlocked())
            {
                var def = t.GetGenericTypeDefinition();

                if(def == typeof(Block16<>))
                    return 16;
                else if(def == typeof(Block32<>))
                    return 32;
                else if (def == typeof(Block64<>))
                    return 64;
                else if (def == typeof(Block128<>))
                    return 128;
                else if (def == typeof(Block256<>))
                    return 256;
                else if (def == typeof(Block512<>))
                    return 512;
                else
                    return 0;
            }
            else
                return 0;
        }

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
        {
            if(t.IsGenericType)
            {
                var tdef = t.GetGenericTypeDefinition();
                if(
                    tdef == typeof(Block16<>) 
                 || tdef == typeof(Block32<>) 
                 || tdef == typeof(Block64<>)
                 || tdef == typeof(Block128<>)
                 || tdef == typeof(Block256<>)
                 || tdef == typeof(Block512<>)
                )
                    return true;                
            }
            return false;
        }
    }
}