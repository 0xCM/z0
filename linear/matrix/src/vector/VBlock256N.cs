//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static nfunc;
    using static zfunc;

    public readonly ref struct VBlock256<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged    
    {
        readonly Block256<T> data;

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static VBlock256<N,T> Load(Span<T> src)
            => new VBlock256<N,T>(src);

        [MethodImpl(Inline)]
        public static VBlock256<N,T> Load(Block256<T> src)
            => new VBlock256<N,T>(src);

        /// <summary>
        /// Specifies the length of the vector, i.e. its component count
        /// </summary>
        public static readonly int Length = nati<N>();     

        /// <summary>
        /// Vec => Slice
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator NatSpan<N,T>(VBlock256<N,T> src)
            => src.data;

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator VBlock256<N,T>(NatSpan<N,T> src)
            => new VBlock256<N,T>(src);

        [MethodImpl(Inline)]   
        public static implicit operator Block256<T>(VBlock256<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator VBlock256<T>(VBlock256<N,T> src)
            => src.Denaturalize();

        [MethodImpl(Inline)]   
        public static implicit operator ConstBlock256<T>(VBlock256<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator VBlock256<N,T>(T[] src)
            => new VBlock256<N, T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (VBlock256<N,T> lhs, in VBlock256<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (VBlock256<N,T> lhs, in VBlock256<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static T operator *(VBlock256<N,T> lhs, in VBlock256<N,T> rhs)
            => mathspan.dot<T>(lhs.Unsized, rhs.Unsized);
         
        [MethodImpl(Inline)]
        internal VBlock256(Span<T> src)
        {
            data = DataBlocks.safeload(n256,src);
        }

        [MethodImpl(Inline)]
        internal VBlock256(Block256<T> src)
        {
            require(src.CellCount >= Length);
            data = src;
        }

        [MethodImpl(Inline)]
        internal VBlock256(NatSpan<N,T> src)
        {
            data = DataBlocks.safeload(n256,src);
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
        public VBlock256<N,U> As<U>()
            where U : unmanaged
                => new VBlock256<N, U>(MemoryMarshal.Cast<T,U>(Unsized));

        public bool Equals(VBlock256<N,T> rhs)
        {
            var lhsData = Unsized;
            var rhsData = rhs.Unsized;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref VBlock256<N,T> CopyTo(ref VBlock256<N,T> dst)
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
        public VBlock256<N,U> Map<U>(Func<T,U> f)
            where U:unmanaged
        {
            var dst = Vector.blockalloc<N,U>();
            return Map(f, ref dst);
        }

        /// <summary>
        /// Projects the source vector onto a caller-supplied target vector of the same length 
        /// via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation function</param>
        /// <typeparam name="U">The target vector element type</typeparam>
        public ref VBlock256<N,U> Map<U>(Func<T,U> f, ref VBlock256<N,U> dst)
            where U:unmanaged
        {
            for(var i=0; i < Length; i++)
                dst[i] = f(data[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public VBlock256<N,U> Convert<U>()
            where U : unmanaged
               => new VBlock256<N,U>(convert<T,U>(data));

        [MethodImpl(Inline)]
        public string Format(char? delimiter = null)
            => data.FormatList(delimiter ?? AsciSym.Comma);    

        public VBlock256<N,T> Replicate(bool structureOnly = false)
            => new VBlock256<N,T>(data.Replicate(structureOnly));

        public VBlock256<T> Denaturalize()
            => data;

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => Format();    
    }
}

