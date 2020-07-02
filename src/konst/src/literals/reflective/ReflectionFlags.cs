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
        ///  All declared public members
        /// </summary>
        public const BindingFlags BF_Public = DeclaredOnly | Public | Instance | Static;

        /// <summary>
        ///  All declared non-public members
        /// </summary>
        public const BindingFlags BF_NonPublic = DeclaredOnly | NonPublic | Instance | Static;

        /// <summary>
        /// All declared static members
        /// </summary>
        public const BindingFlags BF_Static = DeclaredOnly | Public | NonPublic | Static;

        /// <summary>
        ///  All instance mebers
        /// </summary>
        public const BindingFlags BF_Instance = Public | NonPublic | Instance;

        /// <summary>
        /// All declared instance members
        /// </summary>
        public const BindingFlags BF_DeclaredInstance = DeclaredOnly | Public | NonPublic | Instance;

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
        public const BindingFlags BF_NonPublicStatic = DeclaredOnly | NonPublic | Static;

        /// <summary>
        ///  All declared non-public instance members
        /// </summary>
        public const BindingFlags BF_NonPublicInstance = DeclaredOnly | NonPublic | Instance;
                    
        /// <summary>
        /// All declared members
        /// </summary>
        public const BindingFlags BF_Declared = BF_DeclaredInstance | BF_Static;

        /// <summary>
        /// Public, non-public, instance and static members
        /// </summary>
        public const BindingFlags AnyVisibilityOrInstanceType
            = Public
            | NonPublic
            | Instance
            | Static;

        /// <summary>
        ///  All members, declared or inherited
        /// </summary>
        public const BindingFlags BF_All = BF_Instance | BF_Static;
    }
}