//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    public struct ApiPackage
    {
        public OpUri Uri;

        public ApiSig ApiSig;

        public MsilCode CilCode;

        public TextBlock CilText;

        public TextBlock Asm;

        public CodeBlock HexCode;
    }
}