//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    
    /// <summary>
    /// Pairs a located operation with, well, its location
    /// </summary>
    public readonly struct OpAddress : ITextual, IAddressable<OpAddress>
    {        
        public OpUri OpUri {get;}

        public MemoryAddress Address {get;}

        public bool IsEmpty 
        {  
            [MethodImpl(Inline)] 
            get => OpUri.IsEmpty && Address.IsEmpty;
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => !IsEmpty; 
        }

        public OpAddress Zero 
            => Empty;

        [MethodImpl(Inline)]
        public static implicit operator OpAddress((OpUri uri, MemoryAddress address) src)
            => new OpAddress(src.uri, src.address);

        [MethodImpl(Inline)]
        public OpAddress(OpUri uri, MemoryAddress address)
        {
            OpUri = uri;
            Address = address;
        }
        public string Format()
            => OpUri.Format() + Chars.Dash + Address.Format();

        public static OpAddress Empty 
            => (OpUri.Empty, MemoryAddress.Empty);
    }
}