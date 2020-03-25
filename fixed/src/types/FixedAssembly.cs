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

    using static Root;

    public static class FixedAssembly
    {
         [MethodImpl(Inline)]
         public static FixedAssembly<F1,F2> assemble<F1,F2>(in F1 f1, in F2 f2)
            where F1 : unmanaged, IFixed
            where F2 : unmanaged, IFixed
                => new FixedAssembly<F1,F2>(f1,f2);

        [MethodImpl(Inline)]
        public static FixedAssembly<F1,F2,F3> assemble<F1,F2,F3>(in F1 f1, in F2 f2, in F3 f3)
            where F1 : unmanaged, IFixed
            where F2 : unmanaged, IFixed
            where F3 : unmanaged, IFixed
                => new FixedAssembly<F1,F2,F3>(f1,f2,f3);
    }

    public struct FixedAssembly<F1,F2> : IFixed
        where F1 : unmanaged, IFixed
        where F2 : unmanaged, IFixed
    {
        public F1 Field1;

        public F2 Field2;

        public int BitWidth
        {
            [MethodImpl(Inline)]
            get => Field1.BitWidth + Field2.BitWidth;
        }

        public int ByteCount 
        {
            [MethodImpl(Inline)]
            get => Field1.ByteCount + Field2.ByteCount;
        }

        public bool IsByteAligned 
        {
            [MethodImpl(Inline)]
            get => BitWidth % 8 == 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator FixedAssembly<F1,F2>((F1 f1, F2 f2) src)
            => new FixedAssembly<F1,F2>(src.f1, src.f2);

        [MethodImpl(Inline)]
        internal FixedAssembly(in F1 f1, in F2 f2)
        {
            this.Field1 = f1;
            this.Field2 = f2;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out F1 f1, out F2 f2)
        {
            f1 = this.Field1;
            f2 = this.Field2;
        }
    }

    public struct FixedAssembly<F1,F2,F3> : IFixed
        where F1 : unmanaged, IFixed
        where F2 : unmanaged, IFixed
        where F3 : unmanaged, IFixed
    {
        public F1 Field1;

        public F2 Field2;

        public F3 Field3;

        public int BitWidth
        {
            [MethodImpl(Inline)]
            get => Field1.BitWidth + Field2.BitWidth + Field3.BitWidth;
        }

        public int ByteCount 
        {
            [MethodImpl(Inline)]
            get => Field1.ByteCount + Field2.ByteCount + Field3.ByteCount;
        }

        public bool IsByteAligned 
        {
            [MethodImpl(Inline)]
            get => BitWidth % 8 == 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator FixedAssembly<F1,F2,F3>((F1 f1, F2 f2, F3 f3) src)
            => new FixedAssembly<F1,F2,F3>(src.f1, src.f2, src.f3);

        [MethodImpl(Inline)]
        internal FixedAssembly(in F1 f1, in F2 f2, in F3 f3)
        {
            this.Field1 = f1;
            this.Field2 = f2;
            this.Field3 = f3;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out F1 f1, out F2 f2, out F3 f3)
        {
            f1 = this.Field1;
            f2 = this.Field2;
            f3 = this.Field3;
        }
    }
}