//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static RecordField field(text15 name, byte index, uint offset, byte wStore, byte wContent)
            => new RecordField(name, index, offset, wStore, wContent);
    }
}