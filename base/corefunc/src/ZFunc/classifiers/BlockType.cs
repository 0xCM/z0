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

    public static class BlockedType
    {
        /// <summary>
        /// Enumerates the blocked data type definitions
        /// </summary>
        public static IEnumerable<Type> Types
            => items(typeof(Block16<>), typeof(Block32<>), typeof(Block64<>), typeof(Block128<>), typeof(Block256<>), typeof(Block512<>));

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one blocked parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool test(MethodInfo m)
            => m.ReturnType.IsBlocked() || m.ParameterTypes().Any(t => t.IsBlocked());        

        /// <summary>
        /// Determines whether a type is classified as a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool test(Type t)
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

        /// <summary>
        /// Determines the width of a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockWidth width(Type t)
        {
            if(t.IsBlocked())
            {
                var def = t.GetGenericTypeDefinition();

                if(def == typeof(Block16<>))
                    return BlockWidth.W16;
                else if(def == typeof(Block32<>))
                    return BlockWidth.W32;
                else if (def == typeof(Block64<>))
                    return BlockWidth.W64;
                else if (def == typeof(Block128<>))
                    return BlockWidth.W128;
                else if (def == typeof(Block256<>))
                    return BlockWidth.W256;
                else if (def == typeof(Block512<>))
                    return BlockWidth.W512;
                else
                    return 0;
            }
            else
                return 0;
        }

        public static BlockKind kind(BlockWidth width, PrimalKind seg)            
            => (BlockKind)((uint)width | (((uint)seg >> 16) << 16));

        /// <summary>
        /// Determines the segment kind classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static PrimalKind segkind(Type t)
            => test(t) ? t.GetGenericArguments().Single().Kind() : PrimalKind.None;

        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockKind kind(Type t)
            => test(t) ? kind(width(t), segkind(t)) : BlockKind.None;
    }
}