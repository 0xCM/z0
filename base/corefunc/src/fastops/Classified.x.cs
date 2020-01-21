//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class OpApiX
    {
        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => MethodSig.Define(src);

        /// <summary>
        /// Derives an operation descriptor from reflected method metadata and supplied type argments, if applicable
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The arguments over which to close the method, if generic</param>
        [MethodImpl(Inline)]
        public static OpSpec FastOp(this MethodInfo src)
            => FastOps.specify(src);

        [MethodImpl(Inline)]
        public static OpSpec FastOp(this MethodInfo src, Moniker m, Span<byte> buffer)
            => FastOps.specify(src, m, buffer);

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => Classified.segmented(t);

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static FixedWidth Width(this Type t)
            => (FixedWidth)Classified.width(t);
            
        /// <summary>
        /// Returns the number of bytes occupied by a type if it is primal and 0 otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int Size(this Type t)
            => Classified.size(t);
        
        /// <summary>
        /// Retrives the primal kind of the first type parameter, if any
        /// </summary>
        /// <param name="method">The method to test</param>
        /// <param name="n">The generic parameter selector</param>
        [MethodImpl(Inline)]
        public static PrimalKind TypeParameterKind(this MethodInfo method, N1 n)
            => (method.IsGenericMethod ? method.GetGenericArguments() : array<Type>()).FirstOrDefault()?.Kind() ?? PrimalKind.None;

        [MethodImpl(Inline)]
        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF 
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00;
        
        [MethodImpl(Inline)]
        public static BinaryBitLogicKind ToLogical(this BinaryBitLogicKind kind)
            => (BinaryBitLogicKind)kind;

        [MethodImpl(Inline)]
        public static BinaryBitLogicKind ToBitwise(this BinaryBitLogicKind kind)
            => (BinaryBitLogicKind)kind;
    }
}
