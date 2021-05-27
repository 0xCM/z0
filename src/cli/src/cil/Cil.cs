//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using Msil;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Cil
    {
        public static ILVisualizer visualizer()
            => ILVisualizer.service();

        [Op]
        public static string format(CliSig src)
            => DefaultMsilFormatProvider.Instance.SigByteArrayToString(src);

        readonly Index<CilOpCode> Data;

        public ReadOnlySpan<CilOpCode> OpCodes
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [Op]
        public static Cil init()
        {
            var buffer = sys.alloc<CilOpCode>(300);
            ref var dst = ref first(span(buffer));
            OpCodeLoader.load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(CilOpCode[] src)
            => Data = src;
    }
}