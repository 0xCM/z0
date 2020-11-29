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

    /// <summary>
    /// Defines a version schema that supports 2, 3 or 4 32-bit segments
    /// </summary>
    [ApiType, DataType]
    public readonly struct VersionId : IDataType<VersionId>
    {
        readonly Vector128<uint> Storage;

        [MethodImpl(Inline)]
        public VersionId(uint a, uint b)
            => Storage = vparts(w128, a, b, z32, z32);

        [MethodImpl(Inline)]
        public VersionId(uint a, uint b, uint c)
            => Storage = vparts(w128, a, b, c, z32);

        [MethodImpl(Inline)]
        public VersionId(uint a, uint b, uint c, uint d)
            => Storage = vparts(w128, a, b, c, d);

        /// <summary>
        /// The first segment value
        /// </summary>
        public uint A
        {
            [MethodImpl(Inline)]
            get => vcell(Storage,0);
        }

        /// <summary>
        /// The second segment value
        /// </summary>
        public uint B
        {
            [MethodImpl(Inline)]
            get => vcell(Storage,1);
        }

        /// <summary>
        /// The third segment value, or 0 if none
        /// </summary>
        public uint C
        {
            [MethodImpl(Inline)]
            get => vcell(Storage,2);
        }

        /// <summary>
        /// The fourth segment value, or 0 if none
        /// </summary>
        public uint D
        {
            [MethodImpl(Inline)]
            get => vcell(Storage,3);
        }

        [MethodImpl(Inline), Ignore]
        public string Format()
            => text.format(RenderPattern, A, B, C, D);

        public override string ToString()
            => Format();

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

        const string RenderPattern = "{0}.{1}.{2}.{3}";
    }
}