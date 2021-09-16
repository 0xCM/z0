//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    [ApiHost]
    public readonly struct HexMachines
    {
        public const sbyte Unprocessed = -1;

        readonly HexMax Machine;

        [MethodImpl(Inline), Op]
        public static HexMachines init(Vector128<byte> state)
            => new HexMachines(state);

        [MethodImpl(Inline)]
        public HexMachines(Vector128<byte> state)
        {
            Machine = new HexMax(state);
        }

        [MethodImpl(Inline), Op]
        public void Process(ReadOnlySpan<Hex8Seq> data)
        {
            Machine.Process(data);
        }
    }
}