//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    using static Z0.Root;

    readonly struct AsmAssemblyExtractor : IAsmAssemblyExtractor
    {        

        public IAsmContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IAsmAssemblyExtractor Create(IAsmContext context, int? bufferlen = null)
            => new AsmAssemblyExtractor(context,bufferlen);
            
        [MethodImpl(Inline)]
        AsmAssemblyExtractor(IAsmContext context, int? bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen ?? Context.DefaultBufferLength;
        }

        public AnyFiniteSeq<AsmOpExtract> ExtractOps(AssemblyId src)
        {
            var addresses = Context.OpAddresses(src);


            return default;    
        }

    }
}