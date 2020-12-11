//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct DefaultSeqFormat : ISeqFormat<DefaultSeqFormat>
    {
        public static DefaultSeqFormat Default => default;

        public string Delimiter
            => ",";
    }
}