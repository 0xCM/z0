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
    using Z0.Schemas.Ecma;

    partial class PeTableReader
    {
        public static BlobRow sig(in ReaderState state, FieldDefinition src, Count seq)
            => cover(state).Blob(src.Signature, seq);
    }
}