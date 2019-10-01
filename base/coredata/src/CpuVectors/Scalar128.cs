//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    public struct Scalar128<T>
        where T : unmanaged
    {        
        public Vector128<T> mm;            

        [MethodImpl(Inline)]
        public static implicit operator Scalar128<T>(Vector128<T> src)
            => new Scalar128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Scalar128<T>(Vec128<T> src)
            => new Scalar128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Scalar128<T> src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Scalar128<T> src)
            => src.As<T>();

        [MethodImpl(Inline)]
        public Scalar128(Vector128<T> src)
            => this.mm = src;

        public T value
        {
            [MethodImpl(Inline)]
            get => mm.GetElement(0);
        }


        [MethodImpl(Inline)]
        public bool Equals(Scalar128<T> rhs)
            => mm.Equals(rhs.mm);

        public override string ToString()
            => value.ToString();

        [MethodImpl(Inline)]
        public Scalar128<U> As<U>() 
            where U : unmanaged        
                => Unsafe.As<Vector128<T>, Scalar128<U>>(ref Unsafe.AsRef(in mm));        
    }     
}