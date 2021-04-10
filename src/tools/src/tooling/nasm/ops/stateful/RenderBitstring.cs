//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    partial class Nasm
    {
        public string FormatBitstring(in BinaryCode src)
            => BitFormat.Format(src.Storage.Reverse());
    }
}