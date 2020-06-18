//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        /// <summary>
        /// Produces an array from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T[] array<T>(params T[] src)
            => src;
    
        public static void insist(bool invariant)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed");
        }

        /// <summary>
        /// Complains if the source operand, of reference type, is null; otherwise returns it
        /// </summary>
        /// <param name="src">The thing that should not be null</param>
        /// <typeparam name="T">The thing's type</typeparam>
        [MethodImpl(Inline)]
        public static T insist<T>(T src)
            where T : class
        {
            insist(src != null);
            return src;
        }
    }
}