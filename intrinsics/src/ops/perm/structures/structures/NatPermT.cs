//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    /// <summary>
    /// Defines a permutation of natural length N over the natural numbers 0,1,...,N-1
    /// </summary>
    public readonly struct NatPerm<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        readonly PermSpec<T> perm;

        static T nT => convert<T>(natval<N>());

        static int n => natval<N>();

        /// <summary>
        /// The canonical identity permutation of length N
        /// </summary>
        public static NatPerm<N,T> Identity 
            => new NatPerm<N,T>(AllocIdentity());

        /// <summary>
        /// The empty permutation of length N
        /// </summary>
        public static NatPerm<N,T> Empty 
            => new NatPerm<N,T>(new T[n]);

        [MethodImpl(Inline)]
        static T[] AllocIdentity()
            => range<T>(default, convert<T>(n - 1)).ToArray();

        /// <summary>
        /// Allocates an empty permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static NatPerm<N,T> Alloc()
            => Empty.Replicate();

        /// <summary>
        /// Implicitly converts the source to an unsized permutation
        /// </summary>
        /// <param name="f">The permutation to convert</param>
        [MethodImpl(Inline)]
        public static implicit operator PermSpec<T>(NatPerm<N,T> f)
            => f.perm;

        /// <summary>
        /// Computes the composition h of f and g where h(i) = g(f(i)) for i = 0, ... n
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        [MethodImpl(Inline)]
        public static NatPerm<N,T> operator *(NatPerm<N,T> f, NatPerm<N,T> g)
            => f.Compose(g);

        /// <summary>
        /// Computes the inverse of f
        /// </summary>
        /// <param name="f">The source permutation</param>
        [MethodImpl(Inline)]
        public static NatPerm<N,T> operator ~(NatPerm<N,T> f)
            => f.Invert();

        [MethodImpl(Inline)]
        public static NatPerm<N,T> operator ++(in NatPerm<N,T> lhs)
            => lhs.Inc();

        [MethodImpl(Inline)]
        public static NatPerm<N,T> operator --(in NatPerm<N,T> lhs)
            => lhs.Dec();

        [MethodImpl(Inline)]
        public static bool operator ==(NatPerm<N,T> f, NatPerm<N,T> g)
            => f.Equals(g);

        [MethodImpl(Inline)]
        public static bool operator !=(NatPerm<N,T> f, NatPerm<N,T> g)
            => !f.Equals(g);

        /// <summary>
        /// Initializes a permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="swaps">The transpositions to apply to the identity</param>
        [MethodImpl(Inline)]
        public NatPerm(NatSwap<N,T>[] swaps)
        {
            this.perm = new PermSpec<T>(nT, swaps.Unsized());
        }

        [MethodImpl(Inline)]
        NatPerm(PermSpec src)
        {
            this.perm = src.Convert<T>();
        }

        [MethodImpl(Inline)]
        NatPerm(PermSpec<T> src)
        {
            this.perm = src;
        }

        /// <summary>
        /// Initializes a permutation with array content that implicitly defines a permutation
        /// </summary>
        /// <param name="src">The source array</param>
        public NatPerm(T[] src)
        {
            if(src.Length == n)
                perm = new PermSpec<T>(src);
            else
            {
                var tmp = new T[n];
                
                var m = src.Length;                                
                for(var i=0; i< m; i++)
                    tmp[i] = src[i];

                for(var i=m; i< n; i++)
                    tmp[i] = Identity[i - m];
                perm = new PermSpec<T>(tmp);
            }
        }

        public ReadOnlySpan<T> Terms
            => perm.Terms;

        /// <summary>
        /// Term evaluator/manipulator
        /// </summary>
        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref perm[i];
        }

        /// <summary>
        /// Term evaluator/manipulator
        /// </summary>
        public ref T this[T i]
        {
            [MethodImpl(Inline)]
            get => ref perm[i];
        }

        /// <summary>
        /// The permutation length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)n;
        }

        /// <summary>
        /// Effects a transposition (i,j) -> (j, i)
        /// </summary>
        /// <param name="swap">The transposition to apply</param>
        [MethodImpl(Inline)]
        public NatPerm<N,T> Swap(in NatSwap<N> src)
        {            
            perm.Swap(src.ToTuple());
            return this;
        }

        /// <summary>
        /// Effects a transposition (i,j) -> (j, i)
        /// </summary>
        /// <param name="swap">The transposition to apply</param>
        [MethodImpl(Inline)]
        public NatPerm<N,T> Swap(int i, int j)
        {                        
            perm.Swap(i,j);
            return this;
        }

        /// <summary>
        /// Effects a sequence of transpositions
        /// </summary>
        /// <param name="specs">The transpositions to apply</param>
        [MethodImpl(Inline)]
        public NatPerm<N,T> Swap(params (int i, int j)[] specs)
        {            
            
            perm.Swap(specs);
            return this;
        }

        /// <summary>
        /// Effects a sequence of transpositions
        /// </summary>
        public NatPerm<N,T> Swap(params NatSwap<N>[] specs)
        {            
            for(var k=0; k<specs.Length; k++)            
                perm.Swap(specs[k].ToTuple());
            return this;
        }

        /// <summary>
        /// Effects a sequence of transpositions
        /// </summary>
        public NatPerm<N,T> Swap(params NatSwap<N,T>[] specs)
        {            
            for(var k=0; k<specs.Length; k++)            
                perm.Swap(specs[k].ToTuple());
            return this;
        }

        /// <summary>
        /// Clones the permutation
        /// </summary>
        public NatPerm<N,T> Replicate()
            => new NatPerm<N,T>(perm.Replicate());

        /// <summary>
        /// Clones the permutation and applies the transposition (i,j)
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        public NatPerm<N,T> Replicate(in NatSwap<N> s)
        {
            var p = Replicate();
            p.Swap(s);
            return p;
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        public NatPerm<N,T> Shuffle(IPolyrand random)
        {
            perm.Shuffle(random);            
            return this;
        }

        /// <summary>
        /// Reverses the permutation in-place
        /// </summary>
        public NatPerm<N,T> Reverse()
        {
            perm.Reverse();
            return this;
        }

        /// <summary>
        /// Computes the inverse permutation t of the current permutation p 
        /// such that p*t = t*p = I where I denotes the identity permutation
        /// </summary>
        public NatPerm<N,T> Invert()
            => new NatPerm<N,T>(perm.Invert());

        /// <summary>
        /// Creates a new permutation p via composition, p[i] = g(f(i)) for i = 0, ... n
        /// where f denotes the current permutation
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        public NatPerm<N,T> Compose(NatPerm<N,T> g)
            => new NatPerm<N,T>(perm.Compose(g.perm));
 
        /// <summary>
        /// Applies a modular increment to the permutation in-place
        /// </summary>
        [MethodImpl(Inline)]
        public NatPerm<N,T> Inc()
        {
            perm.Inc();
            return this;
        }

        /// <summary>
        /// Applies a modular decrement to the permutation in-place
        /// </summary>
        [MethodImpl(Inline)]
        public NatPerm<N,T> Dec()
        {
            perm.Dec();
            return this;
        }

        /// <summary>
        /// Computes a permutation cycle originating at a specified point
        /// </summary>
        /// <param name="start">The domain point at which evaluation will begin</param>
        public PermCycle<T> Cycle(int start)
            => perm.Cycle(convert<T>(start));

        /// <summary>
        /// Computes a permutation cycle originating at a specified point
        /// </summary>
        /// <param name="start">The domain point at which evaluation will begin</param>
        public PermCycle<T> Cycle(T start)
            => perm.Cycle(start);

        [MethodImpl(Inline)]
        public bool Equals(NatPerm<N,T> g)
            => perm.Equals(g.perm);

        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
        [MethodImpl(Inline)]
         public string Format(int? colwidth = null)
            => perm.Format(colwidth);

         public override string ToString() 
            => this.Format();

         public override int GetHashCode()
            => perm.GetHashCode();

         public override bool Equals(object o)
            => o is NatPerm<N,T> p  && p.perm.Equals(perm);
    }
}