//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public sealed class BitMaskServices : WfService<BitMaskServices, BitMaskServices>
    {
        [Op]
        public static BitMaskFormatter formatter()
            => new BitMaskFormatter();

        public Index<BitMaskInfo> Load()
            => Load(DefaultProvider);

        public Index<BitMaskInfo> Load(Type src)
            => BitMasks.descriptions(src);

        public Index<BitMaskInfo> Emit()
            => Emit(Db.IndexTable<BitMaskInfo>());

        public Index<BitMaskInfo> Emit(FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<BitMaskInfo>(dst);
            var masks = Load();
            Emit(masks.View, dst);
            return masks;
        }

        public WfExecToken Emit(ReadOnlySpan<BitMaskInfo> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<BitMaskInfo>(dst);
            var count = src.Length;
            var f= formatter();
            using var writer = dst.Writer();
            writer.WriteLine(f.HeaderText);
            for(var i=0u; i<count; i++)
                writer.WriteLine(f.Format(skip(src, i)));
            return Wf.EmittedTable<BitMaskInfo>(flow, count, dst);
        }


        static Type DefaultProvider => typeof(BitMasks.Literals);
    }
}