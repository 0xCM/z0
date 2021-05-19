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

    [ApiHost]
    public readonly partial struct ApiSigs
    {
        const string ReturnIndicator = "@return";

        const string Arrow = " -> ";

        const string OperandLead = "::";

        const string TypeParamOpen = "{";

        const string TypeParamClose = "}";

        const string TypeParamSep = ", ";

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

        public static void render(in ApiSig src, ITextBuffer dst)
        {
            var parts = src.Components.View;
            var count = parts.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(skip(parts,i).Name);
                if(i != count - 1)
                    dst.Append(" -> ");
            }
        }
    }
}