//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Konst;

    [ApiHost]
    public readonly struct HexMachines
    {
        public const sbyte Unprocessed = -1;

        readonly HM Machine;

        [MethodImpl(Inline), Op]
        public static HexMachines init(Vector128<byte> state)
            => new HexMachines(state);

        [MethodImpl(Inline)]
        public HexMachines(Vector128<byte> state)
        {
            Machine = new HM(state);
        }
        
        [MethodImpl(Inline), Op]
        public void Process(ReadOnlySpan<HexKind8> data)
        {
            Machine.Process(data);
        }

    }
}