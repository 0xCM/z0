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
        public readonly struct KindedEvalSig : IKindedEvalSig, IEquatable<KindedEvalSig>
        {
            public ApiClassKind Class {get;}

            public EvalSig CoreSig {get;}

            [MethodImpl(Inline)]
            public KindedEvalSig(ApiClassKind @class, EvalSig core)
            {
                Class = @class;
                CoreSig = core;
            }

            public void Render(ITextBuffer dst)
            {
                dst.AppendFormat("{0}:", Class.Format());
                CoreSig.Render(dst);
            }

            public string Format()
            {
                var dst = text.buffer();
                Render(dst);
                return dst.Emit();
            }

            public override string ToString()
                => Format();

            public bool Equals(KindedEvalSig src)
            {
                if(!src.CoreSig.Equals(CoreSig))
                    return false;
                else
                    return src.Class == Class;
            }

            public override int GetHashCode()
                => (int)alg.hash.combine((uint)Class, (uint)CoreSig.GetHashCode());

            public override bool Equals(object src)
                => src is KindedEvalSig s && Equals(s);
        }

        public readonly struct KindedEvalSig<K> : IKindedEvalSig<K>
            where K : unmanaged, IApiKind
        {
            public K Kind => default;

            public EvalSig CoreSig {get;}

            [MethodImpl(Inline)]
            public KindedEvalSig(EvalSig core)
            {
                CoreSig = core;
            }
        }

        public readonly struct KindedEvalSig<K,R> : IKindedEvalSig<K,R>
            where K : unmanaged, IApiKind
        {

            public K Kind => default;

            public EvalSig<R> CoreSig => default;

            [MethodImpl(Inline)]
            public static implicit operator KindedEvalSig<K>(KindedEvalSig<K,R> src)
                => new KindedEvalSig<K>(src.CoreSig);

            [MethodImpl(Inline)]
            public static implicit operator EvalSig<R>(KindedEvalSig<K,R> src)
                => src.CoreSig;

            [MethodImpl(Inline)]
            public static implicit operator EvalSig(KindedEvalSig<K,R> src)
                => src.CoreSig;
        }

        public readonly struct KindedEvalSig<K,A,R> : IKindedEvalSig<K,A,R>
            where K : unmanaged, IApiKind
        {
            public K Kind => default;

            public EvalSig<A,R> CoreSig => default;

            [MethodImpl(Inline)]
            public static implicit operator KindedEvalSig<K>(KindedEvalSig<K,A,R> src)
                => new KindedEvalSig<K>(src.CoreSig);

            [MethodImpl(Inline)]
            public static implicit operator EvalSig<A,R>(KindedEvalSig<K,A,R> src)
                => src.CoreSig;

            [MethodImpl(Inline)]
            public static implicit operator EvalSig(KindedEvalSig<K,A,R> src)
                => src.CoreSig;
        }

        public readonly struct KindedEvalSig<K,A,B,R> : IKindedEvalSig<K,A,B,R>
            where K : unmanaged, IApiKind
        {
            public EvalSig<A,B,R> CoreSig => default;

            [MethodImpl(Inline)]
            public static implicit operator KindedEvalSig<K>(KindedEvalSig<K,A,B,R> src)
                => new KindedEvalSig<K>(src.CoreSig);

            [MethodImpl(Inline)]
            public static implicit operator EvalSig<A,B,R>(KindedEvalSig<K,A,B,R> src)
                => src.CoreSig;

            [MethodImpl(Inline)]
            public static implicit operator EvalSig(KindedEvalSig<K,A,B,R> src)
                => src.CoreSig;
        }

        public readonly struct KindedEvalSig<K,A,B,C,R> : IKindedEvalSig<K,A,B,C,R>
            where K : unmanaged, IApiKind
        {
            public K Kind => default;

            public EvalSig<A,B,C,R> CoreSig => default;

            [MethodImpl(Inline)]
            public static implicit operator KindedEvalSig<K>(KindedEvalSig<K,A,B,C,R> src)
                => new KindedEvalSig<K>(src.CoreSig);

            [MethodImpl(Inline)]
            public static implicit operator EvalSig<A,B,C,R>(KindedEvalSig<K,A,B,C,R> src)
                => src.CoreSig;

            [MethodImpl(Inline)]
            public static implicit operator EvalSig(KindedEvalSig<K,A,B,C,R> src)
                => src.CoreSig;
        }
    }
}