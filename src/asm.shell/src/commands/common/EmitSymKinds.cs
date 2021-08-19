//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        Index<SymKindRow> EmitSymKinds<K>(in Symbols<K> src, FS.FilePath dst)
            where K : unmanaged
        {
            var result = Outcome.Success;
            var kinds = src.Kinds;
            var count = kinds.Length;
            var buffer = alloc<SymKindRow>(count);
            Symbols.kinds(src,buffer);
            TableEmit(@readonly(buffer), SymKindRow.RenderWidths, dst);
            return buffer;
        }
    }
}