//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    [StructLayout(LayoutKind.Sequential), Fixed(FixedWidth.W512)]
    public readonly struct Fixed512  : IFixed<Fixed512,W512,Vector512<ulong>>
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

        [MethodImpl(Inline)]
        Fixed512(Fixed256 x0, Fixed256 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }

        [MethodImpl(Inline)]
        Fixed512(in Vector512<ulong> src)
        {
            this.X0 = src.Lo;
            this.X1 = src.Hi;
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

        // [MethodImpl(Inline)]
        // public Vector256<T> Lo<T>()
        //     where T : unmanaged
        //         => X0.ToVector<T>();

        // [MethodImpl(Inline)]
        // public Vector256<T> Hi<T>()
        //     where T : unmanaged
        //         => X1.ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector512<T> ToVector<T>(in Fixed512 src)
            where T : unmanaged
                => Unsafe.As<Fixed512,Vector512<T>>(ref Unsafe.AsRef(in src));
    }    
}