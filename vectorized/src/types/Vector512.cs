//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Size = 64), CpuVector(FixedWidth.W512)]
    public readonly struct Vector512<T>
        where T : unmanaged
    {        
        /// <summary>
        /// The lo 256 bits 
        /// </summary>
        public readonly Vector256<T> Lo;
        
        /// <summary>
        /// The hi 256 bits
        /// </summary>
        public readonly Vector256<T> Hi;

        /// <summary>
        /// The number of cells covered by the vector
        /// </summary>
        public static int Count => 2*Vector256<T>.Count;

        [MethodImpl(Inline)]
        public static implicit operator Vector512<T>((Vector256<T> a, Vector256<T> b) src)
            => new Vector512<T>(src.a, src.b);

        [MethodImpl(Inline)]
        public static implicit operator Vector512<T>((Vector128<T> a, Vector128<T> b, Vector128<T> c, Vector128<T> d) src)
            => new Vector512<T>(src.a, src.b,src.c, src.d);

        [MethodImpl(Inline)]
        public static implicit operator Vector512<T>(in ConstPair<Vector256<T>> src)
            => new Vector512<T>(src.Left, src.Right);
         
        [MethodImpl(Inline)]
        public static implicit operator ConstPair<Vector256<T>>(Vector512<T> src)
            => (src.Lo, src.Hi);


        [MethodImpl(Inline)]
        public static bool operator ==(in Vector512<T> a, in Vector512<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(in Vector512<T> a, in Vector512<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public Vector512(Vector256<T> a, Vector256<T> b)
        {
            this.Lo = a;
            this.Hi = b;
        }                

        [MethodImpl(Inline)]
        public Vector512(Vector128<T> a, Vector128<T> b, Vector128<T> c, Vector128<T> d)
        {
            this.Lo = Vector256.WithUpper(Vector256.WithLower(default, a), b);
            this.Hi = Vector256.WithUpper(Vector256.WithLower(default, c), d);
        }                

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => default;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out Vector256<T> a, out Vector256<T> b)
        {
            a = this.Lo;
            b = this.Hi;
        }

        /// <summary>
        /// Interprets the pair over an alternate domain
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public Vector512<U> As<U>()
            where U : unmanaged
                => Unsafe.As<Vector512<T>,Vector512<U>>(ref Unsafe.AsRef(in this));

        [MethodImpl(Inline)]
        public bool Equals(in Vector512<T> rhs)
            => Lo.Equals(rhs.Lo) && Hi.Equals(rhs.Hi);


        public override int GetHashCode()
            => HashCode.Combine(Lo,Hi);
        
        public override bool Equals(object obj)
            => obj is Vector512<T> x && Equals(x);

        public override string ToString()
            => string.Join(" ", Lo.ToString(), Hi.ToString());
    }

}