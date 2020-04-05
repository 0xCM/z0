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

    [StructLayout(LayoutKind.Sequential)]
    [Fixed(FixedWidth.W128)]
    public readonly struct Fixed128V : IFixed<Fixed128V,W128,Vector128<ulong>>
    {
        readonly Vector128<ulong> data;

        public int BitWidth => 128;

        public int ByteCount => 16;

        [MethodImpl(Inline)]
        public static Fixed128V From<T>(Vector128<T> src)
            where T : unmanaged
            => new Fixed128V(src.AsUInt64());

        [MethodImpl(Inline)]
        public static Fixed128V From((ulong x0, ulong x1) x)
            => new Fixed128V(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static Fixed128V From(in ConstPair<ulong> x)
            => new Fixed128V(x.Left,x.Right);


        [MethodImpl(Inline)]
        Fixed128V(Vector128<ulong> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        Fixed128V(ulong x0, ulong x1)
        {
            data = Vector128.Create(x0,x1);
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128V((ulong x0, ulong x1) x)
            => From(x);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(in ConstPair<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<byte> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<ushort> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<uint> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(Fixed128V x)
            => x.data.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ushort>(Fixed128V x)
            => x.data.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<uint>(Fixed128V x)
            => x.data.AsUInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(Fixed128V x)
            => x.data.AsUInt64();
                
        [MethodImpl(Inline)]
        public bool Equals(Fixed128V src)
            => data.Equals(src.data);

        [MethodImpl(Inline)]
        public bool Equals(Vector128<ulong> src)
            => data.Equals(src);

        [MethodImpl(Inline)]
        public Vector128<T> ToVector<T>()
            where T : unmanaged
                => data.As<ulong,T>();
        public string Format()
            => data.ToString();

        public override string ToString() 
            => Format();
 
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed128V x && Equals(x);       
    }
}