//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Konst;

    using KVP = System.Collections.Generic.Dictionary<ApiHostUri,HostInstructions>;

    public readonly struct HostInstructionIndex
    {
        public static HostInstructionIndex create()
            => new HostInstructionIndex(new KVP());
        
        readonly KVP Data;

        HostInstructionIndex(KVP src)
        {
            Data = src;
        }

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