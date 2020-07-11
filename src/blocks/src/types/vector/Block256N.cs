//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Konst;
    using static z;

    public readonly ref struct Block256<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged    
    {
        readonly Block256<T> data;

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static Block256<N,T> Load(Span<T> src)
            => new Block256<N,T>(src);

        [MethodImpl(Inline)]
        public static Block256<N,T> Load(Block256<T> src)
            => new Block256<N,T>(src);

        /// <summary>
        /// Specifies the length of the vector, i.e. its component count
        /// </summary>
        public static int Length => (int)value<N>();     

        /// <summary>
        /// Vec => Slice
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator NatSpan<N,T>(Block256<N,T> src)
            => RowVector.natspan<N,T>(src.data);

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Block256<N,T>(NatSpan<N,T> src)
            => new Block256<N,T>(src);

        [MethodImpl(Inline)]   
        public static implicit operator Block256<T>(Block256<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator RowVector256<T>(Block256<N,T> src)
            => src.Denaturalize();

        [MethodImpl(Inline)]   
        public static implicit operator Block256<N,T>(T[] src)
            => new Block256<N, T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (Block256<N,T> lhs, in Block256<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Block256<N,T> lhs, in Block256<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static T operator *(Block256<N,T> lhs, in Block256<N,T> rhs)
            => gmath.dot<T>(lhs.Unsized, rhs.Unsized);
         
        [MethodImpl(Inline)]
        internal Block256(Span<T> src)
        {
            data = Blocks.safeload(n256, src);
        }

        [MethodImpl(Inline)]
        internal Block256(Block256<T> src)
        {
            Root.insist(src.CellCount >= Length);
            data = src;
        }

        [MethodImpl(Inline)]
        internal Block256(NatSpan<N,T> src)
        {
            data = RowVector.safeload(n256,src);
        }
                    
        public ref T this[int index] 
            => ref data[index];

        public Span<T> Unsized
        {
            [MethodImpl(Inline)]
            get => data.Data;
        }
 
        public Block256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public Block256<N,U> As<U>()
            where U : unmanaged
                => new Block256<N, U>(MemoryMarshal.Cast<T,U>(Unsized));

        public bool Equals(Block256<N,T> rhs)
        {
            var lhsData = Unsized;
            var rhsData = rhs.Unsized;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref Block256<N,T> CopyTo(ref Block256<N,T> dst)
        {
            Unsized.CopyTo(dst.Unsized);
            return ref dst;
        }

        /// <summary>
        /// Projects the source vector onto a target vector of the same length 
        /// via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation function</param>
        /// <typeparam name="U">The target vector element type</typeparam>
        [MethodImpl(Inline)]
        public Block256<N,U> Map<U>(Func<T,U> f)
            where U:unmanaged
        {
            var dst = RowVector.blockalloc<N,U>();
            return Map(f, ref dst);
        }

        /// <summary>
        /// Projects the source vector onto a caller-supplied target vector of the same length 
        /// via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation function</param>
        /// <typeparam name="U">The target vector element type</typeparam>
        public ref Block256<N,U> Map<U>(Func<T,U> f, ref Block256<N,U> dst)
            where U:unmanaged
        {
            for(var i=0; i < Length; i++)
                dst[i] = f(data[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public Block256<N,U> Convert<U>()
            where U : unmanaged
               => new Block256<N,U>(Blocks.convert<T,U>(data));

        [MethodImpl(Inline)]
        public string Format()
            => data.Format();    

        public Block256<N,T> Replicate()
            => new Block256<N,T>(data.Replicate());

        public RowVector256<T> Denaturalize()
            => data;

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => Format();    
    }
}