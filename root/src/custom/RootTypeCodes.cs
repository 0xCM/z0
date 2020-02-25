//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Defines type codes for user-defined types owned by the root assembly
    /// </summary>
    public readonly struct RootTypeCodes : ITypeCodeSource<RootTypeCodes>
    {
        static RootTypeCodes TheOnly => default;

        public const ulong BitId = 256;

        public const ulong DurationId = BitId + 1;

        public const ulong BoxedNumberId = DurationId + 1;

        public static UserTypeCode<bit> bit 
            => UserTypeCodes.define(TheOnly, BitId, default(bit));

        public static UserTypeCode<Duration> Duration 
            => UserTypeCodes.define(TheOnly, DurationId, default(Duration));

        public static UserTypeCode<BoxedNumber> BoxedNumber 
            => UserTypeCodes.define(TheOnly, BoxedNumberId, default(BoxedNumber));
    }

}