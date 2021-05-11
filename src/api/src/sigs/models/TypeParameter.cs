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
        /// Represents either a closed or open type parameter
        /// </summary>
        public class TypeParameter : ITypeParameter
        {
            public ushort Position {get;}

            public Name Name {get;}

            public TypeSig Closure {get;}

            [MethodImpl(Inline)]
            public TypeParameter(ushort pos, string name)
            {
                Position = pos;
                Name = name;
                Closure = TypeSig.Empty;
            }

            [MethodImpl(Inline)]
            public TypeParameter(ushort pos, string name, TypeSig closure)
            {
                Position = pos;
                Name = name;
                Closure = closure;
            }

            public bool IsClosed
            {
                [MethodImpl(Inline)]
                get => Closure.IsNonEmpty;
            }

            public bool IsOpen
            {
                [MethodImpl(Inline)]
                get => !IsClosed;
            }
        }
    }
}