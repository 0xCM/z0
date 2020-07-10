//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public interface INeededParts<P>
        where P : unmanaged, Enum
    {
        P Client {get;}
        
        P[] Suppliers {get;}
    }

    public readonly struct NeededParts
    {
        public readonly PartId Client;

        public readonly PartId[] Suppliers;

        [MethodImpl(Inline)]
        public NeededParts(PartId client, PartId[] src)
        {
            Client = client;
            Suppliers = src;
        }
    }
    
    public readonly struct NeededParts<P> : INeededParts<P>
        where P : unmanaged, Enum
    {
        public readonly P Client;
        
        public readonly P[] Suppliers;

        [MethodImpl(Inline)]
        public NeededParts(P client, P[] src)
        {
            Client = client;
            Suppliers = src;
        }
        
        P INeededParts<P>.Client 
            => Client;

        P[] INeededParts<P>.Suppliers 
            => Suppliers;
    }
}
