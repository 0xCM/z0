//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    /// <summary>
    /// Captures name-corellated literals values
    /// </summary>
    public readonly struct LiteralCorrelation<E1,E2> : IFormattable<LiteralCorrelation<E1,E2>>
        where E1: unmanaged, Enum
        where E2: unmanaged, Enum
    {
        /// <summary>
        /// The common name
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The first enum value
        /// </summary>
        public readonly E1 First;

        /// <summary>
        /// The second enum value
        /// </summary>
        public readonly E2 Second;

        [MethodImpl(Inline)]
        internal LiteralCorrelation(string name, E1 first, E2 second)
        {
            this.Name = name;
            this.First = first;
            this.Second = second;
        }

        public string Format()
            => $"{Name} ([{Enums.numeric<ulong>(First)}: {typeof(E1).Name}], [{Enums.numeric<ulong>(Second)}: {typeof(E2).Name}])";

        public override string ToString()
            => Format();            
    }
}
