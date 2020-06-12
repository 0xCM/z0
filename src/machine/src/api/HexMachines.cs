//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static HexLevel;

    [ApiHost]
    public struct HexMachines : IApiHost<HexMachines>
    {
        [MethodImpl(Inline), Op]
        public static HexMachines create(Vector128<byte> state)
            => new HexMachines(state);

        [MethodImpl(Inline), Op]
        public static HM0F h0F(Vector128<byte> state)
            => new HM0F(state);

        [MethodImpl(Inline), Op]
        public static HM1F h1F(Vector128<byte> state)
            => new HM1F(state);

        readonly HM0F M0;

        readonly HM1F M1;

        bit Processed;

        [MethodImpl(Inline)]
        public HexMachines(Vector128<byte> state)
        {
            M0 = h0F(state);
            M1 = h1F(state);
            Processed = false;
        }
        
        [MethodImpl(Inline), Op]
        public void Process(ReadOnlySpan<byte> data, Span<byte> dst)
        {
            ref readonly var src = ref head(data);
            for(var i=0; i<data.Length; i++)
                Process(skip(src, i), dst);
        }

        [MethodImpl(Inline), Op]
        public bit Process(byte src, Span<byte> dst)
        {
            Processed = Process(x00,src);
            if(!Processed)
                Processed = Process(x01,src,dst);            
            return Processed;
        }

        [MethodImpl(Inline), Op]
        bit Process(X00 x, byte src)
            => M0.Process(src);

        [MethodImpl(Inline), Op]
        bit Process(X01 x, byte src, Span<byte> dst)
            => M1.Process(src,dst);
    }
}