//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    partial class PeTableReader
    {
        public static ImageBlob sig(in ReaderState state, FieldDefinition src, Count seq)
            => blob(state, src.Signature, seq);

        public static ImageBlob sig(in ReaderState state, MethodDefinition src, Count seq)
            => blob(state, src.Signature, seq);

    }
}