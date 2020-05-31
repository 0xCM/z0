//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using Z0.Asm;

    using static Seed;

    public readonly struct MachineIndexBuilder : IMachineIndexBuilder
    {
        public static IMachineIndexBuilder Service => new MachineIndexBuilder(0);

        readonly ConcurrentDictionary<MemoryAddress,UriCode> MemoryCode;

        readonly ConcurrentDictionary<MemoryAddress,OpUri> MemoryUri;

        readonly ConcurrentDictionary<OpUri,UriCode> UriCodes;

        MachineIndexBuilder(int x)
        {            
            MemoryCode = new ConcurrentDictionary<MemoryAddress,UriCode>();
            MemoryUri = new ConcurrentDictionary<MemoryAddress,OpUri>();
            UriCodes = new ConcurrentDictionary<OpUri,UriCode>();
        }

        public MachineIndex Freeze()
            => new MachineIndex(MemoryCode, MemoryUri);

        public int Include(params UriCode[] src)
        {
            var count = 0;
            for(var i=0; i<src.Length; i++)
            {
                var code = src[i];
                if(!MemoryCode.TryAdd(code.Address, code))
                    term.yellow($"The address {code.Address} has already been asoociated with code");
                else
                    count++;

                MemoryUri.TryAdd(code.Address, code.OpUri);
                UriCodes.TryAdd(code.OpUri, code);
            }
            return count;
        }
    }
}