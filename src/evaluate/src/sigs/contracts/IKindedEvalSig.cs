//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct EvalSigs
    {
        public interface IKindedEvalSig : IEvalSig
        {
            ApiClassKind Class {get;}

            EvalSig CoreSig {get;}

            Index<Type> IEvalSig.Components
                => CoreSig.Components;
        }

        public interface IKindedEvalSig<K> : IKindedEvalSig
            where K : unmanaged, IApiKind
        {
            K Kind
                => default;

            ApiClassKind IKindedEvalSig.Class
                => Kind.ClassId;
        }

        public interface IKindedEvalSig<K,R> : IEvalSig
            where K : unmanaged, IApiKind
        {
            K Kind => default;

            EvalSig<R> CoreSig {get;}

            Index<Type> IEvalSig.Components
                => CoreSig.Components;
        }

        public interface IKindedEvalSig<K,A,R> : IEvalSig
            where K : unmanaged, IApiKind
        {
            K Kind => default;

            EvalSig<A,R> CoreSig {get;}

            Index<Type> IEvalSig.Components
                => CoreSig.Components;
        }

        public interface IKindedEvalSig<K,A,B,R> : IEvalSig
            where K : unmanaged, IApiKind
        {
            K Kind => default;

            EvalSig<A,B,R> CoreSig {get;}

            Index<Type> IEvalSig.Components
                => CoreSig.Components;
        }

        public interface IKindedEvalSig<K,A,B,C,R> : IEvalSig
            where K : unmanaged, IApiKind
        {
            K Kind => default;

            EvalSig<A,B,C,R> CoreSig {get;}

            Index<Type> IEvalSig.Components
                => CoreSig.Components;
        }
    }
}