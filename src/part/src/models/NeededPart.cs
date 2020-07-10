//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NeededPart<P>
        where P : unmanaged, Enum
    {
        public readonly P Client;

        public readonly P Supplier;
        
        [MethodImpl(Inline)]
        public static implicit operator NeededPart<P>((P client, P supplier) x)
            => new NeededPart<P>(x.client,x.supplier);
        
        [MethodImpl(Inline)]
        public static implicit operator (P client, P supplier)(NeededPart<P> x)
            => (x.Client, x.Supplier);

        [MethodImpl(Inline)]
        public NeededPart(P client, P supplier)
        {
            Client = client;
            Supplier = supplier;            
        }    

        [MethodImpl(Inline)]
        public void Deconstruct(out P client, out P supplier)
        {
            client = Client;
            supplier = Supplier;
        }
    }
}