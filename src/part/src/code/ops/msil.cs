//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static MsilSourceBlock msil(CliToken id, CliSig sig, BinaryCode encoded, MethodImplAttributes attributes = default)
            => new MsilSourceBlock(id, sig, encoded);

        [MethodImpl(Inline), Op]
        public static MsilSourceBlock msil(in ApiMsil src, MethodImplAttributes attributes = default)
            => msil(src.Token, src.CliSig, src.Code, attributes);
    }
}