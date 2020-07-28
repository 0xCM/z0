//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using Z0.Image;
    
    partial class XTend
    {
       public static bool IsPrimitive(this ClrElementType src)
            => ClrQueries.primitive(src);
        
        public static bool IsValueType(this ClrElementType src)
            => ClrQueries.valuetype(src);

        public static bool IsObjectReference(this ClrElementType src)
            => ClrQueries.objref(src);

        public static Type GetTypeForElementType(this ClrElementType src)
            => ClrQueries.represented(src);

        public static string GetName(this ClrRootKind src)
            => ClrQueries.name(src);  

        /// <summary>
        /// Returns true of the specified op-code is a branch to a label.
        /// </summary>
        public static bool IsBranch(this ILOpCode opCode)
            => ClrQueries.branch(opCode);
            
        /// <summary>
        /// Calculate the size of the specified branch instruction operand.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>1 if <paramref name="opCode"/> is a short branch or 4 if it is a long branch.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        public static int GetBranchOperandSize(this ILOpCode opCode)
            => ClrQueries.branchOpSize(opCode);

        /// <summary>
        /// Get a short form of the specified branch op-code.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>Short form of the branch op-code.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        public static ILOpCode GetShortBranch(this ILOpCode opCode)
            => ClrQueries.shortbranch(opCode);

        /// <summary>
        /// Get a long form of the specified branch op-code.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>Long form of the branch op-code.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        public static ILOpCode GetLongBranch(this ILOpCode opCode)
            => ClrQueries.longBranch(opCode);

        public static string GetName(this ClrHandleKind kind) 
            => ClrQueries.name(kind);

        public static int Search<Kind, Key>(this IReadOnlyList<Kind> list, Key key, Func<Kind, Key, int> compareTo)
        {
            int lower = 0;
            int upper = list.Count - 1;

            while (lower <= upper)
            {
                int mid = (lower + upper) >> 1;

                Kind entry = list[mid];
                int comparison = compareTo(entry, key);
                if (comparison > 0)
                {
                    upper = mid - 1;
                }
                else if (comparison < 0)
                {
                    lower = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public static int Search<Kind, Key>(this Kind[] list, Key key, Func<Kind, Key, int> compareTo) 
            => Search((IReadOnlyList<Kind>)list, key, compareTo);
    }
}