//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a version schema that supports 2, 3 or 4 32-bit segments
    /// </summary>
    [ApiType, Datatype]
    public readonly struct VersionId : IDataType<VersionId>
    {
        /// <summary>
        /// The first segment value
        /// </summary>
        public uint A {get;}

        /// <summary>
        /// The second segment value
        /// </summary>
        public uint B {get;}

        /// <summary>
        /// The third segment value, or 0 if none
        /// </summary>
        public uint C {get;}

        /// <summary>
        /// The fourth segment value, or 0 if none
        /// </summary>
        public uint D {get;}

        [MethodImpl(Inline)]
        public VersionId(uint a, uint b, uint c = 0, uint d = 0)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        [MethodImpl(Inline), Ignore]
        public string Format()
            => string.Format(RenderPattern, A, B, C, D);

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