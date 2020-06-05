//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly partial struct MetaRecordKinds
    {
        public static StringRecord String => default;
        
        public static BlobRecord Blob => default;
        
        public static ConstantValueRecord Constant => default;

        public static FieldRecord Field => default;

        public static ManifestResourceRecord ManifestResource => default;

        public static LiteralRecord Literal => default;
    }
}