// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;

    using static As;

    using static zfunc;

    [StructLayout(LayoutKind.Sequential)]
    public ref struct BitMatrix<T>
        where T : unmanaged
    {        
                
        Span<T> data;

        public static readonly uint N = bitsize<T>();

        
        [MethodImpl(Inline)]
        public BitMatrix(params T[] data)
        {
            this.data = data;
        }

        [MethodImpl(Inline)]
        public BitMatrix(Span<T> data)
        {
            this.data = data;
        }

        public Span<T> Rows 
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T Head 
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        readonly public ReadOnlySpan<T> ConstRows
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T this[int row]
        {
            [MethodImpl(Inline)]
            get => ref Row(row);
        }

        [MethodImpl(Inline)]
        public ref T Row(int offset)
            => ref tail(data, offset);
        
        [MethodImpl(Inline)]
        public void Update(Span<T> src)
            => src.CopyTo(data);

        [MethodImpl(Inline)]
        public void Load(int row, out Vector256<T> dst)
        {            
            if(typeof(T) == typeof(byte))
                dst = generic<T>(Vector256.CreateScalar(data.TakeUInt64()));
            else if(typeof(T) == typeof(short))
                ginx.vloadu(in Head, out dst);
            else
                ginx.vloadu(in Row(row), out dst);
        }

        [MethodImpl(Inline)]
        public BitMatrix<S> To<S>()
            where S : unmanaged
                => new BitMatrix<S>(data.As<T,S>());
         
        [MethodImpl(Inline)]
        public ref S HeadAs<S>()
            where S : unmanaged
                => ref Unsafe.As<T,S>(ref head(data));

        public unsafe T* HeadPtr
        {
            [MethodImpl(Inline)]
            get => refptr(ref head(data));
        }

    }

}