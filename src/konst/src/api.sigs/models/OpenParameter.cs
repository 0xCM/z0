//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiSigs
    {
        /// <summary>
        /// Represents a type parameter in a generic artifact definition
        /// </summary>
        public readonly struct OpenParameter : IOpenParameter
        {
            public ushort Position {get;}

            public Name Name {get;}

            [MethodImpl(Inline)]
            public OpenParameter(ushort position, string name)
            {
                Position = position;
                Name = name;
            }
        }
    }
}