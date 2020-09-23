//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Q = ClrQuerySpec;
    using B = System.Reflection.BindingFlags;

    public readonly struct ClrQuerySpecs
    {
        public readonly struct Meanings
        {
            [Meaning(Public, Q.Public)]
            public const string Public = "All declared non-public members";

            [Meaning(NonPublic, Q.NonPublic)]
            public const string NonPublic = "All declared non-public members";

            [Meaning(Static, Q.Static)]
            public const string Static = "All declared static members";

            [Meaning(Instance, Q.Instance)]
            public const string Instance = "All instance members";

            [Meaning(DeclaredInstance, Q.DeclaredInstance)]
            public const string DeclaredInstance = "All declared instance members";

            [Meaning(PublicStatic, Q.PublicInstance)]
            public const string PublicStatic = "All public static members, declared or inherited";

            [Meaning(PublicInstance, Q.PublicInstance)]
            public const string PublicInstance = "All public instance members, declared or inherited";

            [Meaning(NonPublicStatic, Q.NonPublicStatic)]
            public const string NonPublicStatic = "All declared non-public static members";

            [Meaning(NonPublicInstance, Q.NonPublicInstance)]
            public const string NonPublicInstance = "All declared non-public instance members";

            [Meaning(World, Q.Instance)]
            public const string World = "All of the knowable things";

            [Meaning(All, Q.All)]
            public const string All = "All members, declared or inherited";

            [Meaning(Declared, Q.Declared)]
            public const string Declared = "Declared members";

            [Meaning(DeclaredStatic, Q.DeclaredStatic)]
            public const string DeclaredStatic = "Declared static members";
        }

        public readonly struct SystemKinds
        {
            public const B BF_Public = (B)Q.Public;

            public const B BF_NonPublic = (B)Q.NonPublic;

            public const B BF_Static = (B)Q.Static;

            public const B BF_Instance = (B)Q.Instance;

            public const B BF_DeclaredInstance = (B)Q.DeclaredInstance;

            public const B BF_PublicStatic = (B)Q.PublicStatic;

            public const B BF_PublicInstance = (B)Q.PublicInstance;

            public const B BF_NonPublicStatic = (B)Q.NonPublicStatic;

            public const B BF_NonPublicInstance = (B)Q.NonPublicInstance;

            public const B BF_World = (B)Q.World;

            public const B BF_All = (B)Q.All;

            public const B BF_Declared = (B)Q.Declared;

            public const B BF_DeclaredStatic = (B)Q.DeclaredStatic;
        }
    }
}