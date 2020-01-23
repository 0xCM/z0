// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    readonly struct BitMatrixIdentityProvider : ITypeIdentityProvider
    {
        public Moniker DefineIdentity(Type src)
        {
            static string dimensions(int width)
                => concat(width.ToString(), Moniker.SegSep, width.ToString());

            var t = src.EffectiveType();
            var id = "bm";
            id += Moniker.PartSep;

            var order = 0;
            if(t.IsGenericType && t.GetGenericTypeDefinition() ==typeof(BitMatrix<>))
            {
                id += Moniker.GenericIndicator;
                order = PrimalType.width(t.GetGenericArguments().Single().Kind());
            }
            else
            {
                if(t == typeof(BitMatrix8))
                    order = 8;
                else if(t == typeof(BitMatrix16))
                    order = 16;
                else if(t == typeof(BitMatrix32))
                    order = 32;
                else if(t == typeof(BitMatrix64))
                    order = 64;            
            }

            id += dimensions(order);
            return Moniker.Parse(id);            
        }
    }

}