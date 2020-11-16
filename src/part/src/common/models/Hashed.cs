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
    /// Captures a hash code
    /// </summary>
    [DataType]
    public readonly struct Hashed : IHashed
    {
        public uint Hash {get;}

        [MethodImpl(Inline)]
        public Hashed(uint src)
            => Hash = src;

        [MethodImpl(Inline)]
        public Hashed(int src)
            => Hash = (uint)src;

        public override int GetHashCode()
            => (int) Hash;
    }
}