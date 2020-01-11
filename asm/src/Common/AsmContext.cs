//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    // public interface IAsmContext : IContext, IDisposable
    // {
    //     AsmExecBuffer AsmBuffer {get;}
    // }

    // public abstract class AsmContext<T> : Context<T>, IAsmContext
    //     where T : AsmContext<T>, new()
    // {
    //     public static IAsmContext Create(int? buffersize = null)
    //     {
    //         var context = new T();
    //         context.CreateBuffer(buffersize);
    //         return context;        
    //     }
     
    //     protected AsmContext(IPolyrand random, int? buffersize)
    //         : base(random ?? Rng.WyHash64(Seed64.Seed00))
    //     {
    //         CreateBuffer(buffersize);
    //     }

    //     protected AsmContext(IPolyrand random)
    //         : base(random)
    //     {
            
    //     }

    //     protected AsmContext()
    //         : this(Rng.WyHash64(Seed64.Seed00))
    //     {

    //     }

    //     void CreateBuffer(int? size)
    //     {
    //         AsmBuffer =  AsmExecBuffer.Create(size);
    //     }

    //     public AsmExecBuffer AsmBuffer {get; private set;}

    //     public void Dispose()
    //         => AsmBuffer.Dispose();
    // }

    // public sealed class AsmContext : AsmContext<AsmContext>
    // {
    //     public static IAsmContext Create(IPolyrand random = null, int? buffersize = null)
    //         => new AsmContext(random,buffersize);

    //     public static IAsmContext Create<T>(int? buffersize = null)
    //         where T : AsmContext<T>, new()
    //             => AsmContext<T>.Create(buffersize);

    //     public AsmContext()        
    //     {

    //     }

    //     AsmContext(IPolyrand random, int? buffersize)
    //         : base(random,buffersize)
    //     {

    //     }

    // }

}
