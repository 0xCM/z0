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
        public readonly struct ClosedParameter : IClosedParameter
        {
            public ushort Position {get;}

            public Name Name {get;}

            public TypeSig Closure {get;}

            [MethodImpl(Inline)]
            internal ClosedParameter(ushort position, string name, TypeSig closure)
            {
                Position = position;
                Name = name;
                Closure = closure;
            }
        }
    }
}