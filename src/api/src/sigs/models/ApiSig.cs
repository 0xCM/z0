//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct ApiSig : IApiSig, IEquatable<ApiSig>
    {
        public Index<Type> Components {get;}

        public ApiClassKind Class {get;}

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
            Render(dst);
            return dst.Emit();
        }

        public void Render(ITextBuffer dst)
        {
            var parts = Components.View;
            var count = parts.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(skip(parts,i).Name);
                if(i != count - 1)
                    dst.Append(" -> ");
            }
        }

        public override string ToString()
            => Format();

        public bool Equals(ApiSig src)
        {
            var count = Components.Length;
            if(count != src.Components.Length)
                return false;

            if(Class != src.Class)
                return false;

            var left = Components.View;
            var right = src.Components.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var a = ref skip(left,i);
                ref readonly var b = ref skip(right,i);
                if(!a.Equals(b))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            var result = 0u;
            var src = Components.View;
            var count = Components.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(src,i);
                var hc = alg.hash.marvin(part.Name);
                if(i == 0)
                    result = hc;
                else
                    result = alg.hash.combine(result, hc);
            }

            return (int) alg.hash.combine(result, (uint)Class);
        }

        public override bool Equals(object src)
            => src is ApiSig s && Equals(s);
    }
}