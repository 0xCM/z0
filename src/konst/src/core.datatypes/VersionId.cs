//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    [ApiDataType]
    public readonly struct VersionId : ITextual
    {
        readonly Vector128<uint> Data;

        [MethodImpl(Inline)]
        public static implicit operator VersionId(ConstPair<uint> src)
            => new VersionId(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator VersionId(Pair<uint> src)
            => new VersionId(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator VersionId(ConstTriple<uint> src)
            => new VersionId(src.First, src.Second, src.Third);

        [MethodImpl(Inline)]
        public static implicit operator VersionId(ConstQuad<uint> src)
            => new VersionId(src.First, src.Second, src.Third, src.Fourth);

        [MethodImpl(Inline)]
        public VersionId(uint a, uint b)
        {
            Data = vparts(w128, a, b, z32, z32);
        }

        [MethodImpl(Inline)]
        public VersionId(uint a, uint b, uint c)
        {
            Data = vparts(w128, a, b, c, z32);
        }

        [MethodImpl(Inline)]
        public VersionId(uint a, uint b, uint c, uint d)
        {
            Data = vparts(w128, a, b, c, d);
        }

        public uint A
        {
            [MethodImpl(Inline)]
            get => vcell(Data,0);
        }

        public uint B
        {
            [MethodImpl(Inline)]
            get => vcell(Data,1);
        }

        public uint C
        {
            [MethodImpl(Inline)]
            get => vcell(Data,2);
        }

        public uint D
        {
            [MethodImpl(Inline)]
            get => vcell(Data,3);
        }

        [MethodImpl(Inline), Ignore]
        public string Format()
            => text.format(RenderPattern, A, B, C, D);


        const string RenderPattern = "{0}.{1}.{2}.{3}";
    }
}