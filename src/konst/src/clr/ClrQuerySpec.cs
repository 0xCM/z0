//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using B = System.Reflection.BindingFlags;

    [Flags]
    public enum ClrQuerySpec : uint
    {
        /// <summary>
        ///  The default query sort
        /// </summary>
        Default = All,

        /// <summary>
        ///  All declared non-public members
        /// </summary>
        Public = B.FlattenHierarchy | B.Public | B.Instance | B.Static,

        /// <summary>
        ///  All declared non-public members
        /// </summary>
        NonPublic = B.FlattenHierarchy | B.NonPublic | B.Instance | B.Static,

        /// <summary>
        /// All declared static members
        /// </summary>
        Static = B.FlattenHierarchy | B.Public | B.NonPublic | B.Static,

        /// <summary>
        ///  All instance members
        /// </summary>
        Instance = B.FlattenHierarchy | B.Public | B.NonPublic | B.Instance,

        /// <summary>
        /// All declared instance members
        /// </summary>
        DeclaredInstance = B.FlattenHierarchy | B.Public | B.NonPublic | B.Instance,

        /// <summary>
        ///  All public static members, declared or inherited
        /// </summary>
        PublicStatic = B.FlattenHierarchy | B.Public | B.Static,

        /// <summary>
        ///  All public instance members, declared or inherited
        /// </summary>
        PublicInstance = B.FlattenHierarchy | B.Public | B.Instance,

        /// <summary>
        ///  All declared non-public static members
        /// </summary>
        NonPublicStatic = B.FlattenHierarchy | B.NonPublic | B.Static,

        /// <summary>
        ///  All declared non-public instance members
        /// </summary>
        NonPublicInstance = B.FlattenHierarchy | B.NonPublic | B.Instance,

        /// <summary>
        /// All of the knowable things
        /// </summary>
        World = NonPublicStatic | NonPublicInstance | PublicInstance | PublicStatic,

        /// <summary>
        ///  All members, declared or inherited
        /// </summary>
        All = Public | Static | NonPublic | Instance,

        Declared = B.DeclaredOnly | Public | Static | NonPublic | Instance,

        DeclaredStatic = B.DeclaredOnly | Public | NonPublic | Static,
    }
}