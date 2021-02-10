//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ExtractState
    {
        /// <summary>
        /// The captured data
        /// </summary>
        public byte Captured {get;}

        [MethodImpl(Inline)]
        public ExtractState(byte captured)
            => Captured = captured;

        /// <summary>
        /// The empty state
        /// </summary>
        public static ExtractState Empty
            => default;
    }
}