//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmToken
    {
        public uint Kind {get;}

        public string Expression {get;}

        [MethodImpl(Inline)]
        public AsmToken(uint kind, string expression)
        {
            Kind = kind;
            Expression = expression;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmToken((uint kind, string expr) src)
            => new AsmToken(src.kind, src.expr);
    }

    public readonly struct AsmToken<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public string Expression {get;}

        [MethodImpl(Inline)]
        public AsmToken(K kind, string expression)
        {
            Kind = kind;
            Expression = expression;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmToken<K>((K kind, string expr) src)
            => new AsmToken<K>(src.kind, src.expr);

        [MethodImpl(Inline)]
        public static implicit operator AsmToken(AsmToken<K> src)
            => new AsmToken(core.bw32(src.Kind), src.Expression);
    }
}