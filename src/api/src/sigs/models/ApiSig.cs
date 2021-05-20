//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = ApiSigs;

    public class ApiSig : IEquatable<ApiSig>
    {
        public ApiClassKind Class {get;}

        public Index<Type> Components {get;}

        [MethodImpl(Inline)]
        public ApiSig(Index<Type> components)
        {
            Class = 0;
            Components = components;
        }

        [MethodImpl(Inline)]
        public ApiSig(ApiClassKind @class, Index<Type> components)
        {
            Class = @class;
            Components = components;
        }

        public string Format()
        {
            var dst = text.buffer();
            api.render(this, dst);
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public bool Equals(ApiSig src)
            => api.eq(this, src);

        public override int GetHashCode()
            => (int)api.hash(this);

        public override bool Equals(object src)
            => src is ApiSig s && Equals(s);
    }
}