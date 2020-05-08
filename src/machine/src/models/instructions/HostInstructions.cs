//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Collects a sequence of operation instuction sequences from host-defined members
    /// </summary>         
    public readonly struct HostInstructions : IInstructions<HostInstructions, OpInstructions>
    {
        public static HostInstructions Empty => new HostInstructions(ApiHostUri.Empty, Control.array<OpInstructions>());

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public OpInstructions[] Instructions {get;}

        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The number of host-defined operations
        /// </summary>
        public int OpCount => Instructions.Length;

        /// <summary>
        /// The total instruction count
        /// </summary>
        public int Count => Instructions.Sum(i => i.Count);

        [MethodImpl(Inline)]
        public static HostInstructions Create(ApiHostUri host, OpInstructions[] src)
            => new HostInstructions(host, src);
    
        [MethodImpl(Inline)]        
        public HostInstructions(ApiHostUri host, OpInstructions[] inxs)
        {
            Host = host;
            Instructions = inxs;
        }
    }
}