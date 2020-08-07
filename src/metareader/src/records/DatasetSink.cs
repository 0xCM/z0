//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DatasetSink<S,R>
        where S : unmanaged, Enum
        where R : struct
    {                                                        
        readonly IDatasetFormatter<S> Target;
                
        readonly DatasetRelay<S,R> Relay;
        
        [MethodImpl(Inline)]
        public DatasetSink(IDatasetFormatter<S> dst, DatasetRelay<S,R> relay)
        {
            Target = dst;            
            Relay = relay;
        }

        [MethodImpl(Inline)]
        public void Deposit(in R src)
        {
            Relay(src, Target);
        }

        [MethodImpl(Inline)]
        public string Render()
            => Target.Format(); 
    }    
}