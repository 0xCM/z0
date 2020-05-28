//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
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
        readonly HexMachine0F M0;

        readonly HexMachine1F M1;

        bit Processed;

        [MethodImpl(Inline), Op]
        public static HexMachines Create(Vector128<byte> state)
            => new HexMachines(state);

        [MethodImpl(Inline)]
        public HexMachines(Vector128<byte> state)
        {
            M0 = HexMachine0F.Create(state);
            M1 = HexMachine1F.Create(state);
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