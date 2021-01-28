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
        /// Extracts the Vendor segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Vendor vendor(DocRef src)
            => (Vendor)(((ulong)F.Vendor & (ulong)src) >> (int)D.Vendor);

        /// <summary>
        /// Initializes an empty bitfield with a Vendor segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static DocRef vendor(Vendor src)
            => (ulong)src << (byte)D.Vendor;
    }
}