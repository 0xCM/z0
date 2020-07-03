//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static Konst;

    using K = MemoryOpKind;
    using I = IMemoryOpKind;

    /// <summary>
    /// Characterizes a system operation classifier
    /// </summary>
    public interface IMemoryOpKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        OpKindId IOpKind.KindId 
            => (OpKindId)Kind;        
    }    


    /// <summary>
    /// Characterizes a reified system operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IMemoryOpKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        OpKindId IOpKind.KindId 
            => default(F).KindId;        
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric system operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IMemoryOpKind<F,T> : IMemoryOpKind<F>
        where F : unmanaged, I
    {
        K I.Kind 
            => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind 
            => NumericKinds.kind<T>();
    }
}