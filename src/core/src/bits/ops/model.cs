//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct BitfieldSpecs
    {
        public static BitfieldModel model(StringAddress name, Index<BitfieldSectionSpec> sections)
            => new BitfieldModel(name,sections);
    }
}