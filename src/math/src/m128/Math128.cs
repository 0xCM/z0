//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public readonly partial struct Math128
    {
        /// <summary>
        /// Zero, the the one and only.
        /// </summary>
        public static ConstPair<ulong> Zero
            => default;

        /// <summary>
        /// One, just.
        /// </summary>
        public static ConstPair<ulong> One
            => (1,0);

        /// <summary>
        /// One, so many
        /// </summary>
        public static ConstPair<ulong> Ones
            => (ulong.MaxValue, ulong.MaxValue);
    }
}