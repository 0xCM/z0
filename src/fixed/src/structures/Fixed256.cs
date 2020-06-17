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

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static Memories;

    [Fixed(FixedWidth.W256)]
    public readonly struct Fixed256 : IFixed<Fixed256,W256,Vector256<ulong>>
    {
        public static Fixed256 Empty => default(Fixed256);        

        internal readonly Vector256<ulong> Data;

        public Vector256<ulong> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Fixed128 Lo
        {
            [MethodImpl(Inline)]
            get => Vector256.GetLower(Data);
        }

        public Fixed128 Hi
        {
            [MethodImpl(Inline)]
            get => Vector256.GetUpper(Data);
        }

        public int BitWidth => 256;

        public int ByteCount => 32;

        public Fixed256 Zero 
        {
            [MethodImpl(Inline)]
            get => Empty; 
        }    

        [MethodImpl(Inline)]
        public static Fixed256 From<T>(Vector256<T> src)
            where T : unmanaged
                => new Fixed256(v64u(src));

        [MethodImpl(Inline)]
        public static Fixed256 From<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            var z = vinsert(v64u(x), default, 0);
            return new Fixed256(vinsert(v64u(y),z,1));
        }

        [MethodImpl(Inline)]
        public static Fixed256 From(Fixed128 x, Fixed128 y)
        {
            var x1 = Fixed.vector<ulong>(x);
            var y1 = Fixed.vector<ulong>(y);
            var z = vinsert(x1,default, 0);
            return new Fixed256(vinsert(y1,z,1));
        }
            
        [MethodImpl(Inline)]
        internal Fixed256(Vector256<ulong> src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed256((Fixed128 x, Fixed128 y) src)
            => From(src.x,src.y);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<byte> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<ushort> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<uint> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(Fixed256 x)
            => x.Data.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ushort>(Fixed256 x)
            => x.Data.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<uint>(Fixed256 x)
            => x.Data.AsUInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ulong>(Fixed256 x)
            => x.Data.AsUInt64();
                
        [MethodImpl(Inline)]
        public bool Equals(Fixed256 src)
            => Data.Equals(src.Data);

        [MethodImpl(Inline)]
        public bool Equals(Vector256<ulong> src)
            => Data.Equals(src);

        [MethodImpl(Inline)]
        public Vector256<T> ToVector<T>()
            where T : unmanaged
                => Data.As<ulong,T>();

        public string Format() 
            => Data.ToString();
 
        public override string ToString() 
            => Format();
 
        public override int GetHashCode()
            => Data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed256 x && Equals(x);

        [MethodImpl(Inline), Op]
        static Vector256<ulong> vinsert(Vector128<ulong> src, Vector256<ulong> dst, [Imm] byte index)        
            => InsertVector128(dst, src, index); 
    }
}