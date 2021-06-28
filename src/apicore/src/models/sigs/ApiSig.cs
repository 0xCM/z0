//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public class ApiSig : IEquatable<ApiSig>
    {
        public ApiClass Class {get;}

        public Index<Type> Components {get;}

        [MethodImpl(Inline)]
        public ApiSig(Index<Type> components)
        {
            Class = ApiClass.Empty;
            Components = components;
        }

        [MethodImpl(Inline)]
        public ApiSig(ApiClass @class, Index<Type> components)
        {
            Class = @class;
            Components = components;
        }

        public string Format()
        {
            var dst = TextTools.buffer();
            ApiSigRender.render(this, dst);
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public bool Equals(ApiSig src)
            => eq(this, src);

        public override int GetHashCode()
            => (int)hash(this);

        public override bool Equals(object src)
            => src is ApiSig s && Equals(s);

        [Op]
        public static uint hash(in ApiSig src)
        {
            var result = 0u;
            var parts = src.Components.View;
            var count = src.Components.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                var hc = alg.hash.marvin(part.Name);
                if(i == 0)
                    result = hc;
                else
                    result = alg.hash.combine(result, hc);
            }

            return alg.hash.combine(result, (uint)src.Class);
        }

        [Op]
        public static bool eq(in ApiSig a, in ApiSig b)
        {
            var count = a.Components.Length;
            if(count != b.Components.Length)
                return false;

            if(a.Class != b.Class)
                return false;

            var left = a.Components.View;
            var right = b.Components.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(left,i);
                ref readonly var y = ref skip(right,i);
                if(!x.Equals(y))
                    return false;
            }
            return true;
        }
    }
}