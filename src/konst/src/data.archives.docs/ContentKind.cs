//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public enum ContentKind : uint
    {
        None = 0,

        Asm = 1,

        Csv = 2,

        Hex = 4,

    }

    public readonly struct ContentKind<H> : IContentKind<ContentKind<H>,ContentKind,string>
        where H : struct, IContentKind<H,ContentKind,string>
    {
        readonly H Spec;

        [MethodImpl(Inline)]
        public ContentKind(H src)
            => Spec = src;

        public ContentKind Kind
        {
            [MethodImpl(Inline)]
            get => Spec.Kind;
        }

        public string Id
        {
            [MethodImpl(Inline)]
            get => Spec.Id;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Spec.Format();

        public override string ToString()
            => Spec.ToString();

        public static implicit operator ContentKind<H>(H spec)
            => new ContentKind<H>(spec);
    }
}