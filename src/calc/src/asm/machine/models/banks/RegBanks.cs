//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct RegBanks
    {
        [MethodImpl(Inline), Op]
        public static GpRegAlloc gp64(RegAlloc src)
            => new GpRegAlloc(src);

        [MethodImpl(Inline), Op]
        public static XmmRegAlloc xmm(RegAlloc src)
            => new XmmRegAlloc(src);

        [MethodImpl(Inline), Op]
        public static YmmRegAlloc ymm(RegAlloc src)
            => new YmmRegAlloc(src);

        [MethodImpl(Inline), Op]
        public static ZmmRegAlloc zmm(RegAlloc src)
            => new ZmmRegAlloc(src);

        static long FileSeqKeys;

        static long RegSeqKeys;

        [Op]
        public static RegFile file(W64 gp, W512 zmm)
        {
            var a = new RegSeqSpec((uint)inc(ref RegSeqKeys), 16, 8);
            var b = new RegSeqSpec((uint)inc(ref RegSeqKeys), 32, 64);
            var c = new RegSeqSpec[2]{a,b};
            return new RegFile((uint)inc(ref FileSeqKeys),c);
        }

        [Op]
        public static RegBank allocate(W64 gp, W512 zmm)
            => allocate(file(gp,zmm));

        /// <summary>
        /// Alocates a set of register representations over a contiguous sequence of native memory
        /// </summary>
        /// <param name="file">The allocation spec</param>
        [Op]
        public static RegBank allocate(RegFile file)
        {
            ref readonly var specs = ref file.Spec(0);
            var count = file.SeqCount;
            var size = ByteSize.Zero;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref seek(specs,i);
                size += (spec.RegSize*spec.RegCount);
            }

            var buffer = memory.native(size);
            buffer.Clear();
            var @base = buffer.Address;
            var address = @base;
            var allocations = alloc<RegAlloc>(count);
            ref var allocation = ref first(allocations);

            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref seek(specs,i);
                var tokens = memory.tokenize(address, spec.RegSize, spec.RegCount);
                seek(allocations,i) = new RegAlloc(spec,tokens);
                var blockSize = spec.RegCount*spec.RegSize;
                address += blockSize;
            }

            return new RegBank(file, buffer, allocations);
        }
    }
}