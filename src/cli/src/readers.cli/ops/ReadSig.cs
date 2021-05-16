//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;

    using static Root;
    using static core;
    using static CliRows;

    partial class CliReader
    {
        [MethodImpl(Inline), Op]
        public BinaryCode ReadSig(FieldDefinition src)
            => Read(src.Signature);

        [MethodImpl(Inline), Op]
        public BinaryCode ReadSig(MethodDefinition src)
            => Read(src.Signature);
    }
}