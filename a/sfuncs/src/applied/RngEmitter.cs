//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    // public readonly struct NumericRngEmitter<T> : ISEmitter<T>
    //     where T : unmanaged
    // {
    //     public const string Name = "random";

    //     readonly IPolyrand Random;

    //     public OpIdentity Id => Identify.SFunc<T>(Name);

    //     [MethodImpl(Inline)]
    //     public NumericRngEmitter(IPolyrand random)            
    //         => this.Random = random;
        
    //     [MethodImpl(Inline)]
    //     public T Invoke() => Random.Next<T>();
    // }

    // public readonly struct RngEmitter<T> : ISEmitter<T>
    //     where T : unmanaged
    // {
    //     public OpIdentity Id {get;}

    //     readonly IPolyrand Random;
        
    //     readonly Emitter<T> f;

    //     [MethodImpl(Inline)]
    //     public RngEmitter(IPolyrand random, Emitter<T> f, OpIdentity id)      
    //     {      
    //         this.Random = random;
    //         this.f = f;
    //         this.Id = id;
    //     }

    //     [MethodImpl(Inline)]
    //     public T Invoke() => f.Invoke();
    // }    

    // public readonly struct SegmentedRngEmitter<F,T> : ISEmitter<F>
    //     where F : unmanaged
    //     where T :unmanaged
    // {
    //     public OpIdentity Id {get;}
    //     readonly IPolyrand Random;
        
    //     readonly Emitter<F> f;

    //     public const string Name = "segmented_emitter";

    //     public static int Width => BitSize.measure<F>();

    //     public static NumericKind NumericKind 
    //     {
    //         [MethodImpl(Inline)]
    //         get => typeof(T).NumericKind();
    //     }
        
    //     [MethodImpl(Inline)]
    //     public SegmentedRngEmitter(IPolyrand random, Emitter<F> f, OpIdentity id)      
    //     {      
    //         this.Random = random;
    //         this.f = f;
    //         this.Id = id;

    //     }

    //     [MethodImpl(Inline)]
    //     public F Invoke() => f.Invoke();
    // }
}