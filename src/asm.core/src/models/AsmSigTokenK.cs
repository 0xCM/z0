//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    using static AsmSigTokens;

    [StructLayout(LayoutKind.Sequential, Size=2)]
    public readonly struct AsmSigToken<K>
        where K : unmanaged
    {
        public SigTokenKind Kind {get;}

        readonly byte _Value;

        [MethodImpl(Inline)]
        public AsmSigToken(SigTokenKind kind, K value)
        {
            Kind = kind;
            _Value = @as<K,byte>(value);
        }

        public K Value
        {
            [MethodImpl(Inline)]
            get => @as<byte,K>(_Value);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSigToken<K>((SigTokenKind kind, K value) src)
            => new AsmSigToken<K>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator AsmSigToken(AsmSigToken<K> src)
            => new AsmSigToken(src.Kind, src._Value);
    }
}