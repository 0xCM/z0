//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using KVP = System.Collections.Generic.Dictionary<ApiHostUri,HostInstructions>;

    public readonly struct HostAsmFxIndex
    {
        public static HostAsmFxIndex create()
            => new HostAsmFxIndex(new KVP());
        
        readonly KVP Data;

        [MethodImpl(Inline)]
        public HostAsmFxIndex(KVP src)
            => Data = src;

        public HostInstructions this[ApiHostUri host]
        {
            get => Data[host];
            set => Data[host] = value;
        }        

        public ApiHostUri[] Hosts
        {
            get => Data.Keys.Array();
        }        
    }
}