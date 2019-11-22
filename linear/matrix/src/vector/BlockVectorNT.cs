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

    public readonly ref struct BlockVector<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged    
    {
        readonly Block256<T> data;

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(ref T src)
            => new BlockVector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(NatBlock<N,T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(ReadOnlySpan<T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(Span<T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(Block256<T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(params T[] src)
            => new BlockVector<N, T>(src);

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
        public static implicit operator NatBlock<N,T>(BlockVector<N,T> src)
            => src.data;

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator BlockVector<N,T>(NatBlock<N,T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]   
        public static implicit operator Block256<T>(BlockVector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator BlockVector<T>(BlockVector<N,T> src)
            => src.Denaturalize();

        [MethodImpl(Inline)]   
        public static implicit operator ConstBlock256<T>(BlockVector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator BlockVector<N,T>(T[] src)
            => new BlockVector<N, T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (BlockVector<N,T> lhs, in BlockVector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BlockVector<N,T> lhs, in BlockVector<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static T operator *(BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            => mathspan.dot<T>(lhs.Unsized, rhs.Unsized);
         
        [MethodImpl(Inline)]
        BlockVector(ref T src)
        {  
            data =  Block256.load<T>(ref src, Length);  
        }

        [MethodImpl(Inline)]
        BlockVector(in ReadOnlySpan<T> src)
        {
            data = Block256.load(src);
        }

        [MethodImpl(Inline)]
        BlockVector(Span<T> src)
        {
            data = Block256.load(src);
        }


        [MethodImpl(Inline)]
        BlockVector(Block256<T> src)
        {
            require(src.Length >= Length);
            data = src;
        }

        [MethodImpl(Inline)]
        BlockVector(NatBlock<N,T> src)
        {
            data = Block256.load(src);
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
        public BlockVector<N,U> As<U>()
            where U : unmanaged
                => new BlockVector<N, U>(MemoryMarshal.Cast<T,U>(Unsized));

        public bool Equals(BlockVector<N,T> rhs)
        {
            var lhsData = Unsized;
            var rhsData = rhs.Unsized;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref BlockVector<N,T> CopyTo(ref BlockVector<N,T> dst)
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
        public BlockVector<N,U> Map<U>(Func<T,U> f)
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
        public ref BlockVector<N,U> Map<U>(Func<T,U> f, ref BlockVector<N,U> dst)
            where U:unmanaged
        {
            for(var i=0; i < Length; i++)
                dst[i] = f(data[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public BlockVector<N,U> Convert<U>()
            where U : unmanaged
               => new BlockVector<N,U>(convert<T,U>(data));

        [MethodImpl(Inline)]
        public string Format(char? delimiter = null)
            => data.FormatList(delimiter ?? AsciSym.Comma);    

        public BlockVector<N,T> Replicate(bool structureOnly = false)
            => new BlockVector<N,T>(data.Replicate(structureOnly));

        public BlockVector<T> Denaturalize()
            => data;

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => Format();
    
        public Block256<T> ToSpan256()
            => data;

        public ConstBlock256<T> ToReadOnlySpan256()
            => data;
    }
}

