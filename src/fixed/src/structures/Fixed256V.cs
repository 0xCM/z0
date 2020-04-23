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

    using static Seed;
    using static Memories;

    [StructLayout(LayoutKind.Sequential), Fixed(FixedWidth.W256)]
    public readonly struct Fixed256V : IFixed<Fixed256V,W256,Vector256<ulong>>
    {
        readonly Vector256<ulong> data;

        public int BitWidth => 256;

        public int ByteCount => 32;

        [MethodImpl(Inline)]
        public static Fixed256V From<T>(Vector256<T> src)
            where T : unmanaged
                => new Fixed256V(v64u(src));

        [MethodImpl(Inline)]
        public static Fixed256V From<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            var z = vinsert(v64u(x), default, 0);
            return new Fixed256V(vinsert(v64u(y),z,1));
        }

        [MethodImpl(Inline)]
        public static Fixed256V From(Fixed128V x, Fixed128V y)
        {
            var x1 = Fixed.vector<ulong>(x);
            var y1 = Fixed.vector<ulong>(y);
            var z = vinsert(x1,default, 0);
            return new Fixed256V(vinsert(y1,z,1));
        }
            
        [MethodImpl(Inline)]
        internal Fixed256V(Vector256<ulong> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V((Fixed128V x, Fixed128V y) src)
            => From(src.x,src.y);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<byte> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<ushort> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<uint> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(Fixed256V x)
            => x.data.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ushort>(Fixed256V x)
            => x.data.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<uint>(Fixed256V x)
            => x.data.AsUInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ulong>(Fixed256V x)
            => x.data.AsUInt64();
                
        [MethodImpl(Inline)]
        public bool Equals(Fixed256V src)
            => data.Equals(src.data);

        [MethodImpl(Inline)]
        public bool Equals(Vector256<ulong> src)
            => data.Equals(src);

        [MethodImpl(Inline)]
        public Vector256<T> ToVector<T>()
            where T : unmanaged
                => data.As<ulong,T>();

        public string Format() 
            => data.ToString();
 
        public override string ToString() 
            => Format();
 
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed256V x && Equals(x);

        [MethodImpl(Inline), Op]
        static Vector256<ulong> vinsert(Vector128<ulong> src, Vector256<ulong> dst, [Imm] byte index)        
            => InsertVector128(dst, src, index); 
    }
}