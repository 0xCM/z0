//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static System.Reflection.BindingFlags;

    /// <summary>
    /// Defines useful collection of reflection binding flags
    /// </summary>
    public static class ReflectionFlags
    {
        /// <summary>
        ///  All declared non-public members
        /// </summary>
        public const BindingFlags BF_Public = FlattenHierarchy | Public | Instance | Static;

        /// <summary>
        ///  All declared non-public members
        /// </summary>
        public const BindingFlags BF_NonPublic = FlattenHierarchy | NonPublic | Instance | Static;

        /// <summary>
        /// All declared static members
        /// </summary>
        public const BindingFlags BF_Static = FlattenHierarchy | Public | NonPublic | Static;

        /// <summary>
        ///  All instance mebers
        /// </summary>
        public const BindingFlags BF_Instance = FlattenHierarchy | Public | NonPublic | Instance;

        /// <summary>
        /// All declared instance members
        /// </summary>
        public const BindingFlags BF_DeclaredInstance =  FlattenHierarchy | Public | NonPublic | Instance;

        /// <summary>
        ///  All public static members, declared or inherited
        /// </summary>
        public const BindingFlags BF_PublicStatic = FlattenHierarchy | Public | Static;

        /// <summary>
        ///  All public instance members, declared or inherited
        /// </summary>
        public const BindingFlags BF_PublicInstance = FlattenHierarchy | Public | Instance;

        /// <summary>
        ///  All declared non-public static members
        /// </summary>
        public const BindingFlags BF_NonPublicStatic = FlattenHierarchy | NonPublic | Static;

        /// <summary>
        ///  All declared non-public instance members
        /// </summary>
        public const BindingFlags BF_NonPublicInstance = FlattenHierarchy | NonPublic | Instance;
                    
        /// <summary>
        ///  All members, declared or inherited
        /// </summary>
        public const BindingFlags BF_All = BF_Public | BF_Static | BF_NonPublic | BF_Instance;
    }
}