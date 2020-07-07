//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = Fixed512;

    public readonly struct Fixed512  : IFixedW<Fixed512,W512,Vector512<ulong>>
    {
        readonly Fixed256 X0;

        readonly Fixed256 X1;

        public Vector512<ulong> Content
        {
            [MethodImpl(Inline)]
            get => (X0, X1);
        }

        public Fixed256 Lo
        {
            [MethodImpl(Inline)]
            get => X0;
        }

        public Fixed256 Hi
        {
            [MethodImpl(Inline)]
            get => X1;
        }

        public int BitWidth => 512;

        public int ByteCount => 64;

        public Fixed512 Zero 
        {
            [MethodImpl(Inline)]
            get => Empty; 
        }

        [MethodImpl(Inline)]
        public Fixed512(Fixed256 x0, Fixed256 x1)
        {
            X0 = x0;
            X1 = x1;
        }

        [MethodImpl(Inline)]
        public Fixed512(in Vector512<ulong> src)
        {
            X0 = src.Lo;
            X1 = src.Hi;
        }

        [MethodImpl(Inline)]
        public static Fixed512 From<T>(in Vector512<T> src)
            where T : unmanaged
                => new Fixed512(src.As<ulong>());

        [MethodImpl(Inline)]
        public static implicit operator Fixed512((Fixed256 x0, Fixed256 x1) x)
            => new Fixed512(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(in Vector512<byte> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(in Vector512<ushort> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(in Vector512<uint> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(in Vector512<ulong> x)
            => From(x);
        public string Format() 
            => Arrays.from(X0,X1).Format();

        [MethodImpl(Inline)]
        public bool Equals(Fixed512 src)
            => X0.Equals(src.X0) && X1.Equals(src.X1);

        [MethodImpl(Inline)]
        public bool Equals(Vector512<ulong> src)
            => Content.Equals(src);

        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed512 x && Equals(x);

        public override string ToString() 
            => Format();              

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
                => In.generic<F,T>(this);
         
        [MethodImpl(Inline)]
        public Vector512<T> ToVector<T>()
            where T : unmanaged
                => Unsafe.As<Fixed512,Vector512<T>>(ref Unsafe.AsRef(this));

        public static Fixed512 Empty => default;

    }    
}