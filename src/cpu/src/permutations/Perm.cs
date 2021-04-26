//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static BitMasks.Literals;
    using static Part;
    using static memory;
    using static PermLits;

    /// <summary>
    /// Defines a permutation over the integers [0, 1, ..., n - 1] where n is the permutation length
    /// </summary>
    [ApiHost]
    public readonly partial struct Permute
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a fixed 16-bit permutation over a generic permutation over 16 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm16 perm16(W128 w, Perm<byte> spec)
            => new Perm16(gcpu.vload(w128, spec.Terms));

        /// <summary>
        /// Creates a fixed 32-bit permutation over a generic permutation over 32 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm32 perm32(W256 w, Perm<byte> src)
            => new Perm32(gcpu.vload(w, src.Terms));

        [MethodImpl(Inline), Op]
        public static Perm16 perm16(Vector128<byte> data)
            => new Perm16(cpu.vand(data, cpu.vbroadcast(w128, Msb8x8x3)));

        [MethodImpl(Inline), Op]
        public static Perm32 perm32(Vector256<byte> data)
            => new Perm32(cpu.vand(data, cpu.vbroadcast(w256, Msb8x8x3)));

        [MethodImpl(Inline), Op]
        public static Perm8L permid(N8 n)
            => Perm8Identity;

        [MethodImpl(Inline), Op]
        public static Perm16L permid(N16 n)
            => Perm16Identity;

        [MethodImpl(Inline), Op]
        public static Vector128<byte> shuffles(NatPerm<N16> src)
            => cpu.vload(w128, (byte)first(src.Terms));

        [MethodImpl(Inline), Op]
        public static Perm32 unsize(in NatPerm<N32,byte> spec)
            => new Perm32(gcpu.vload(w256, spec.Terms));

        [MethodImpl(Inline), Op]
        public static Perm16 unsize(in NatPerm<N16,byte> spec)
            => new Perm16(gcpu.vload(w128, spec.Terms));

        /// <summary>
        /// Defines the permutation (0 -> terms[0], 1 -> terms[1], ..., n - 1 -> terms[n-1])
        /// where n is the length of the array
        /// </summary>
        readonly int[] terms;

        /// <summary>
        /// Shuffles span content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void apply<T>(Permute p, ReadOnlySpan<T> src, Span<T> dst)
        {
            var terms = span(p.terms);
            var count = terms.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(src,(uint)skip(terms,i));
        }

        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> apply<T>(Span<T> src, params Swap[] swaps)
            where T : unmanaged
        {
            var len = swaps.Length;
            ref var srcmem = ref first(src);
            ref var swapmem = ref memory.first(swaps);
            for(var k = 0u; k < len; k++)
            {
                (var i, var j) = skip(swapmem, k);
               Swaps.swap(ref seek(srcmem, i), ref seek(srcmem, j));
            }
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<T> apply<T>(Permute p, ReadOnlySpan<T> src)
        {
            var dst = sys.alloc<T>(src.Length);
            apply(p,src, dst);
            return dst;
        }

        /// <summary>
        /// Applies a transposition sequence to an input sequence
        /// </summary>
        /// <param name="src">The input sequence</param>
        /// <param name="swaps">The transposition sequence</param>
        /// <param name="dst">The output sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void apply<T>(ReadOnlySpan<T> src, ReadOnlySpan<Swap> swaps, Span<T> dst)
            where T : unmanaged
        {
            var len = swaps.Length;
            ref readonly var input = ref first(src);
            ref readonly var exchange = ref first(swaps);
            for(var k = 0u; k<len; k++)
            {
                ref readonly var x = ref skip(exchange, k);
                Swaps.swap(ref seek(input, x.i), ref seek(input, x.j));
            }
        }

        /// <summary>
        /// Creates a generic permutation by application of a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> Build<T>(T n, params (T i, T j)[] swaps)
            where T : unmanaged
                => new Perm<T>(n, swaps);

        /// <summary>
        /// Creates a generic permutation by application of a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> Build<T>(T n, params Swap<T>[] swaps)
            where T : unmanaged
                => new Perm<T>(n,swaps);

        /// <summary>
        /// Allocates an empty permutation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Permute Alloc(int n)
            => new Permute(new int[n]);

        /// <summary>
        /// Allocates an empty permutation of specified length
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> Alloc<T>(uint n)
            where T : unmanaged
                => new Perm<T>(new T[n]);

        /// <summary>
        /// Defines an untyped permutation determined by values in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline), Op]
        public static Permute Init(ReadOnlySpan<int> src)
            => new Permute(src.ToArray());

        /// <summary>
        /// Creates a permutation from the elements in a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> init<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new Perm<T>(src.ToArray());

        /// <summary>
        /// Initializes permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="swaps">The transpositions applied to the identity</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> init<T>(T n, (T i, T j)[] swaps)
            where T : unmanaged
                => new Perm<T>(n, swaps);

        /// <summary>
        ///  Initializes permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="swaps">The transpositions applied to the identity</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> init<T>(T n, Swap<T>[] swaps)
            where T : unmanaged
                => new Perm<T>(n, swaps);

        /// <summary>
        /// Creates a permutation from the elements in a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> init<T>(Span<T> src)
            where T : unmanaged
                => new Perm<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> init<T>(IEnumerable<T> src)
            where T : unmanaged
                => new Perm<T>(src);

        /// <summary>
        /// Creates a permutation from the elements in a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> init<T>(params T[] src)
            where T : unmanaged
                => new Perm<T>(src);

        /// <summary>
        /// Defines an identity permutation on n symbols
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Perm<T> Identity<T>(T n)
            where T : unmanaged
                => new Perm<T>(gAlg.stream(default, gmath.dec(n)));

        /// <summary>
        /// Distills a natural permutation on 4 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm4L pack(NatPerm<N4> src)
        {
            const int segwidth = 2;
            const int length = 4;

            var dst = 0u;
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (uint)src[i] << offset;
            return (Perm4L)dst;
        }

        /// <summary>
        /// Distills a natural permutation on 8 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm8L pack(NatPerm<N8> src)
        {
            const int segwidth = 3;
            const int length = 8;

            var dst = 0u;
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (uint)src[i] << offset;
            return (Perm8L)dst;
        }

        /// <summary>
        /// Distills a natural permutation on 16 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm16L pack(NatPerm<N16> src)
        {
            const int segwidth = 4;
            const int length = 16;

            var dst = 0ul;
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (ulong)src[i] << offset;
            return (Perm16L)dst;
        }

        /// <summary>
        /// Defines an identity permutation of natural length and applies a specified sequence of transpostions
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(N n, params NatSwap<N>[] swaps)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(swaps);

        /// <summary>
        /// Defines an identity permutation of natural length and applies a specified sequence of transpostions
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(params NatSwap<N>[] swaps)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(swaps);

        /// <summary>
        /// Defines a permutation of natural length
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that define the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        public static NatPerm<N> natural<N>(N n, ReadOnlySpan<int> terms)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(terms.ToArray());

        /// <summary>
        /// Defines a permutation of natural length
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(N n, params int[] terms)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(terms);

        /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar specification
        /// </summary>
        /// <param name="spec">The representative</param>
        [MethodImpl(Inline), Op]
        public static ref readonly NatPerm<N4> natural(Perm4L spec, in NatPerm<N4> dst)
        {
            uint data = (byte)spec;
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=2)
                dst[i] = (int)cpu.segment(data, (byte)offset, (byte)(offset + 1));
            return ref dst;
        }

        public static NatPerm<N4> natural(Perm4L spec)
            => natural(spec, NatPerm<N4>.Alloc());

        /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar specification
        /// </summary>
        /// <param name="spec">The representative</param>
        [Op]
        public static NatPerm<N8> natural(Perm8L spec)
        {
            uint data = (uint)spec;
            var dst = NatPerm<N8>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=3)
                dst[i] = (int)cpu.segment(data, (byte)offset, (byte)(offset + 2));
            return dst;
        }

        /// <summary>
        /// Reifies a permutation of length 16 from its canonical scalar representative
        /// </summary>
        /// <param name="spec">The representative</param>
        [MethodImpl(Inline), Op]
        public static ref readonly NatPerm<N16> natural(Perm16L spec, in NatPerm<N16> dst)
        {
            ulong data = (ulong)spec;
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=4)
                dst[i] = (int)cpu.segment(data, (byte)offset, (byte)(offset + 3));
            return ref dst;
        }

        /// <summary>
        /// Reifies a permutation of length 16 from its canonical scalar representative
        /// </summary>
        /// <param name="spec">The representative</param>
        [MethodImpl(Inline), Op]
        public static NatPerm<N16> natural(Perm16L spec)
            => natural(spec, NatPerm<N16>.Alloc());

        /// <summary>
        /// Creates a new identity permutation of natural length
        /// </summary>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The term type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatPerm<N>.Identity.Replicate();

        public static NatPerm<N,T> natural<N,T>(N n, ReadOnlySpan<T> terms)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(terms.Length != TypeNats.nat32i(n))
                AppErrors.ThrowInvariantFailure($"{n} != {terms.Length}");
            return new NatPerm<N,T>(Permute.init(terms));
        }

        public static NatPerm<N,T> natural<N,T>(N n, Span<T> terms)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natural(n, terms.ReadOnly());

        [MethodImpl(Inline)]
        public Permute(int n, Swap[] src)
        {
            terms = identity(n).terms;
            Apply(src);
        }

        [MethodImpl(Inline)]
        public Permute(int[] src)
        {
            terms = src;
        }

        [Op]
        void Absorb(ReadOnlySpan<int> src)
        {
            var n = terms.Length;
            var m = src.Length;
            ref var dst = ref first(terms);

            for(var i=0; i<m; i++)
                seek(dst, i) = skip(src,i);

            var identity = Permute.identity(n);
            for(var i=m; i<n; i++)
                seek(dst, i) = identity[i - m];
        }

        public Permute(int n, int[] src)
        {
            terms = new int[n];
            Absorb(src);
        }

        [MethodImpl(Inline)]
        public Permute(IEnumerable<int> src)
        {
            terms = src.ToArray();
        }

        /// <summary>
        /// Term accessor where the term index is in the inclusive range [0, N-1]
        /// </summary>
        public ref int this[int i]
        {
            [MethodImpl(Inline)]
            get => ref terms[i];
        }

        /// <summary>
        /// Term accessor where the term index is in the inclusive range [0, N-1]
        /// </summary>
        public ref int this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref terms[i];
        }

        /// <summary>
        /// Effects an in-place transposition, returning the result for convenience
        /// </summary>
        /// <remarks>
        /// A transposition (l,r) is interpreted as a function composition
        /// that carries the l-value (from the domain) to the r-value
        /// (in the l-relative codomain) and then the r-value to the l-value
        /// (in the r-relative codomain & l-relative domain). So, if
        /// a function f sends l to r and a function g sends r to l then
        /// the transposition t is the function t(l) = g(f(l)) == l.
        /// </remarks>
        [MethodImpl(Inline)]
        public Permute Swap(int i, int j)
        {
            Swaps.swap(ref terms[i], ref terms[j]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of in-place transpositions
        /// </summary>
        public Permute Swap(params (int i, int j)[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                Swaps.swap(ref terms[specs[k].i], ref terms[specs[k].j]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of in-place transpositions
        /// </summary>
        public Permute Apply(params Swap[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                Swaps.swap(ref terms[specs[k].i], ref terms[specs[k].j]);
            return this;
        }

        /// <summary>
        /// The length of the permutation
        /// </summary>
        public int Length
            => terms.Length;

        public ReadOnlySpan<int> Terms
            => terms;

        /// <summary>
        /// Clones the permutation
        /// </summary>
        public Permute Replicate()
            => new Permute(terms.Replicate());

        /// <summary>
        /// Creates a new permutation p via composition, p[i] = g(f(i)) for i = 0, ... n
        /// where f denotes the current permutation
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        public Permute Compose(Permute g)
        {
            var n = terms.Length;
            var dst = Alloc(n);
            var f = this;
            for(var i=0; i< n; i++)
                dst[i] = g[f[i]];
            return dst;
        }

        /// <summary>
        /// Reverses the permutation in-place
        /// </summary>
        [MethodImpl(Inline)]
        public Permute Reverse()
        {
            terms.Reverse();
            return this;
        }

        /// <summary>
        /// Computes the inverse permutation t of the current permutation p
        /// such that p*t = t*p = I where I denotes the identity permutation
        /// </summary>
        public Permute Invert()
        {
            var dst = Alloc(Length);
            for(var i=0; i< Length; i++)
                dst[terms[i]] = i;
            return dst;
        }

        /// <summary>
        /// Applies a modular increment to the permutation in-place
        /// </summary>
        public Permute Inc()
        {
            Span<int> src = Replicate().terms;
            var k = 1;
            for(var i=0; i< Length - k; i++)
                terms[i] = src[i + k];
            terms[Length - k] = src[k - 1];
            return this;
        }

        /// <summary>
        /// Applies a modular decrement to the permutation in-place
        /// </summary>
        public Permute Dec()
        {
            Span<int> src = Replicate().terms;
            terms[0] = src[Length - 1];
            for(var i=1; i< Length; i++)
                terms[i] = src[i - 1];
            return this;
        }

        /// <summary>
        /// Converts the permutation to a generic permutation over the specified target type
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        public Perm<T> Convert<T>()
            where T : unmanaged
        {
            var dst = new T[terms.Length];
            for(var i=0; i<terms.Length; i++)
                dst[i] = Numeric.force<T>(terms[i]);
            return new Perm<T>(dst);
        }

        public Span<Swap> CalcSwaps()
        {
            var max = terms.Length/2;
            Span<Swap> swaps = new Swap[max];
            var count = 0;
            for(var i=0; i< max; i++)
            {
                var image = terms[i];

                if(i != image)
                {
                    var a = terms[image];
                    var b = terms[a];
                    if(image == b)
                        swaps[count++] = (a,image);
                }
            }

            return swaps.Slice(0,count);
        }

        /// <summary>
        /// Computes a permutation cycle originating at a specified point
        /// </summary>
        /// <param name="start">The domain point at which evaluation will begin</param>
        public PermCycle Cycle(int start)
        {
            root.require(start >= 0 && start < Length, () => $"{start} doesn't work");
            Span<PermTerm> cterms = stackalloc PermTerm[Length];
            var traversed = new HashSet<int>(Length);
            var index = start;
            var ctix = 0;

            while(true)
            {
                var image = terms[index];
                if(traversed.Contains(image))
                    break;
                else
                {
                    traversed.Add(image);
                    cterms[ctix++] = new PermTerm(index, image);
                    index = image;
                }
            }

            return new PermCycle(cterms.Slice(0, ctix).ToArray());
        }

        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
        [MethodImpl(Inline)]
        public string Format(int? colwidth = null)
            => Terms.FormatAsPerm(colwidth);

        public override int GetHashCode()
            => terms.GetHashCode();

        public bool Equals(Permute rhs)
        {
            var len = rhs.Length;
            if(len != terms.Length)
                return(false);

            for(var i=0; i<len; i++)
                if(terms[i] != rhs.terms[i])
                    return false;

            return true;
        }

        public override bool Equals(object o)
            => o is Permute p  && Equals(p);

        [MethodImpl(Inline)]
        public static implicit operator Permute(Span<int> src)
            => new Permute(src.ToArray());

        [MethodImpl(Inline)]
        public static implicit operator Permute(ReadOnlySpan<int> src)
            => Init(src);

        /// <summary>
        /// Computes the composition h of f and g where f and g have common length n and
        /// h(i) = g(f(i)) for i = 0, ... n-1
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        [MethodImpl(Inline)]
        public static Permute operator *(Permute f, Permute g)
            => f.Compose(g);

        [MethodImpl(Inline)]
        public static Permute operator ++(in Permute src)
            => src.Inc();

        [MethodImpl(Inline)]
        public static Permute operator --(in Permute src)
            => src.Dec();

        [MethodImpl(Inline)]
        public static bool operator ==(Permute a, Permute b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Permute a, Permute b)
            => !(a == b);
    }
}