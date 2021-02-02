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

    public readonly struct MsilCode
    {
        public CliSig Sig {get;}

        public Index<byte> Data {get;}

        [MethodImpl(Inline)]
        public MsilCode(CliSig sig, Index<byte> data)
        {
            Sig = sig;
            Data = data;
        }
    }

    public struct ApiPackage
    {
        public OpUri Uri;

        public object ApiSig;

        public MsilCode CilCode;

        public TextBlock CilText;

        public TextBlock Asm;

        public CodeBlock HexCode;
    }
}