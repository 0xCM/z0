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


    partial class PeTableReader
    {
        public static CliBlobInfo sig(in ReaderState state, FieldDefinition src, Count seq)
            => blob(state, src.Signature, seq);
    }
}