//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CreditTypes;

    using D = CreditTypes.DocFieldDelimiter;
    using F = CreditTypes.DocField;

    public partial class Credits
    {
        /// <summary>
        /// Extracts the Topic segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Topic topic(DocRef src)
            => (Topic)(((ulong)F.Topic & (ulong)src) >> (int)D.Topic);

        /// <summary>
        /// Initializes an empty bitfield with a Topic segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static DocRef topic(Topic src)
            => (ulong)src << (byte)D.Topic;
    }
}