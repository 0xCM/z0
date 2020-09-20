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

    using api = Literals;

    [ApiProviderAttribute(DataStructure)]
    public readonly struct BinaryLiteral<T> : ILiteral<BinaryLiteral<T>,T>
        where T : unmanaged
    {
        public string Name {get;}

        public T Data {get;}

        public string Text {get;}

        [MethodImpl(Inline)]
        public BinaryLiteral(string name, T value, string text)
        {
            Name = name;
            Data = value;
            Text = text;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => api.empty(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => api.nonempty(this);
        }

        public BinaryLiteral<T> Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();


        [MethodImpl(Inline)]
        public bool Equals(BinaryLiteral<T> src)
            => api.eq(this, src);

        public static BinaryLiteral<T> Empty
            => new BinaryLiteral<T>(EmptyString, default, EmptyString);
    }
}