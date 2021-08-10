//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1,Size=16)]
    public struct ContentKind
    {

    }

    [LiteralProvider]
    public readonly struct ContentSpecifiers
    {
        public const string exe = "exe";

        public const string zip = "zip";

        public const string obj = "obj";

        public const string hex = "hex";

        public const string array = "array";
    }

    public readonly struct ContentType
    {
        public ContentKind Kind {get;}

        [MethodImpl(Inline)]
        public ContentType(ContentKind kind)
        {
            Kind = kind;
        }
    }

    [ApiHost]
    public readonly struct ContentTypes
    {

    }
}