//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public sealed class ModRm : WfService<ModRm>
    {
        Index<ModRmBits> _Table;

        public ModRm()
        {
            AsmEncoding.table(out _Table);
        }

        public ReadOnlySpan<ModRmBits> Table
        {
            [MethodImpl(Inline), Op]
            get => _Table;
        }
    }
}