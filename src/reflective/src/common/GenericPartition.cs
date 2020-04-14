//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public enum GenericPartition : byte
    {        
        /// <summary>
        /// Indicates subject is nongeneric
        /// </summary>
        NonGeneric = 0,

        /// <summary>
        /// Indicates subject is generic
        /// </summary>
        Generic = 1

    }

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bool IsGeneric(this GenericPartition src)
            => src == GenericPartition.Generic;
    }
}