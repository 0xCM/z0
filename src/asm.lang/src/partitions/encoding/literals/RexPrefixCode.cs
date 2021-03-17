//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    using D = RexPrefixDescriptions;
    using T = RexPrefixToken;

    /// <summary>
    /// Defines the rex prefix codes
    /// </summary>
    [PrefixCodes]
    public enum RexPrefixCode : byte
    {
        None = 0,

        /// <summary>
        /// Defines the <see cref='x40'/> prefix [0100 0000]
        /// </summary>
        [PrefixCode(T.Rex40, D.Rex40)]
        Rex40 = x40,

        /// <summary>
        /// Defines the <see cref='x41'/> prefix [0100 0001]
        /// </summary>
        [PrefixCode(T.Rex41, D.Rex41)]
        RexB = x41,

        /// <summary>
        /// Defines the <see cref='x42'/> prefix [0100 0010]
        /// </summary>
        [PrefixCode(T.Rex42, D.Rex42)]
        Rex42 = x42,

        /// <summary>
        /// Defines the <see cref='x43'/> prefix [0100 0011]
        /// </summary>
        [PrefixCode(T.Rex43, D.Rex43)]
        Rex43 = x43,

        /// <summary>
        /// Defines the <see cref='x44'/> prefix [0100 0100]
        /// </summary>
        [PrefixCode(T.Rex44, D.Rex44)]
        RexR = x44,

        /// <summary>
        /// Defines the <see cref='x45'/> prefix [0100 0101]
        /// </summary>
        [PrefixCode(T.Rex45, D.Rex45)]
        Rex45 = x45,

        /// <summary>
        /// Defines the <see cref='x46'/> prefix [0100 0110]
        /// </summary>
        [PrefixCode(T.Rex46, D.Rex46)]
        Rex46 = x46,

        /// <summary>
        /// Defines the <see cref='x47'/> prefix [0100 0111]
        /// </summary>
        [PrefixCode(T.Rex47, D.Rex47)]
        Rex47 = x47,

        /// <summary>
        /// Defines the <see cref='x48'/> prefix [0100 1000]
        /// </summary>
        [PrefixCode(T.Rex48, D.Rex48)]
        Rex48 = x48,

        /// <summary>
        /// Defines the <see cref='x49'/> prefix [0100 1001]
        /// </summary>
        [PrefixCode(T.Rex49, D.Rex49)]
        Rex49 = x49,

        /// <summary>
        /// Defines the <see cref='x4a'/> prefix [0100 1010]
        /// </summary>
        [PrefixCode(T.Rex4A, D.Rex4A)]
        Rex4A = x4a,

        /// <summary>
        /// Defines the <see cref='x4b'/> prefix [0100 1011]
        /// </summary>
        [PrefixCode(T.Rex4B, D.Rex4B)]
        Rex4B = x4b,

        /// <summary>
        /// Defines the <see cref='x4c'/> prefix [0100 1100]
        /// </summary>
        [PrefixCode(T.Rex4C, D.Rex4C)]
        Rex4C = x4c,

        /// <summary>
        /// Defines the <see cref='x4d'/> prefix [0100 1101]
        /// </summary>
        [PrefixCode(T.Rex4D, D.Rex4D)]
        Rex4D = x4d,

        /// <summary>
        /// Defines the <see cref='x4e'/> prefix [0100 1110]
        /// </summary>
        [PrefixCode(T.Rex4E, D.Rex4E)]
        Rex4E = x4e,

        /// <summary>
        /// Defines the <see cref='x4f'/> prefix [0100 1111]
        /// </summary>
        [PrefixCode(T.Rex4F, D.Rex4F)]
        Rex4F = x4f,
    }

    [LiteralProvider]
    readonly struct RexPrefixDescriptions
    {
        public const string Rex40 = "40h | [0100 0000] | W:0 | R:0 | X:0 | B:0";

        public const string Rex41 = "41h | [0100 0001] | W:0 | R:0 | X:0 | B:1";

        public const string Rex42 = "42h | [0100 0010] | W:0 | R:0 | X:1 | B:0";

        public const string Rex43 = "43h | [0100 0011] | W:0 | R:0 | X:1 | B:1";

        public const string Rex44 = "44h | [0100 0100] | W:0 | R:1 | X:0 | B:0";

        public const string Rex45 = "45h | [0100 0101] | W:0 | R:1 | X:0 | B:1";

        public const string Rex46 = "46h | [0100 0110] | W:0 | R:1 | X:1 | B:0";

        public const string Rex47 = "47h | [0100 0111] | W:0 | R:1 | X:1 | B:1";

        public const string Rex48 = "48h | [0100 1000] | W:1 | R:0 | X:0 | B:0";

        public const string Rex49 = "49h | [0100 1001] | W:1 | R:0 | X:0 | B:1";

        public const string Rex4A = "4ah | [0100 1010] | W:1 | R:0 | X:1 | B:0";

        public const string Rex4B = "4bh | [0100 1011] | W:1 | R:0 | X:1 | B:1";

        public const string Rex4C = "4ch | [0100 1100] | W:1 | R:1 | X:0 | B:0";

        public const string Rex4D = "4dh | [0100 1101] | W:1 | R:1 | X:0 | B:1";

        public const string Rex4E = "4eh | [0100 1110] | W:1 | R:1 | X:1 | B:0";

        public const string Rex4F = "4fh | [0100 1111] | W:1 | R:1 | X:1 | B:1";
    }
}