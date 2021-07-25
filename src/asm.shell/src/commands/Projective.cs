//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Projective
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Domain<D> domain<D>(D descriptor)
            where D : unmanaged
                => new Domain<D>(descriptor);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Source untype<T>(Source<T> src, Func<Source<T>,uint> f)
            => new Source(src.Domain, f(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Target untype<T>(Target<T> src, Func<Target<T>,uint> f)
            => new Target(src.Domain, f(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Source<T> source<T>(Domain d, T rep)
            => new Source<T>(d,rep);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Target<T> target<T>(Domain d, T rep)
            => new Target<T>(d,rep);

        [MethodImpl(Inline)]
        public static Projection<S,T> projection<S,T>(uint id, Source<T> src, Target<T> dst)
            => new Projection<S,T>(id,src,dst);

        [MethodImpl(Inline)]
        public static Projection projection(uint id, Source src, Target dst)
            => new Projection(id, src, dst);

        [MethodImpl(Inline)]
        public static Projection untype<S,T>(Projection<S,T> p, Func<Source<T>,uint> f, Func<Target<T>,uint> g)
        {
            var src = untype(p.Source,f);
            var dst = untype(p.Target,g);
            return new Projection(p.Id,src,dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Domain untyped<D>(Domain<D> d)
            where D : unmanaged
        {
            var k = 0u;
            var i = 0u;
            var data = @readonly(bytes(d.Descriptor));
            if(size<D>() == 1)
            {
                ref readonly var b = ref skip(data,0);
                k = (uint)b & 0xF;
                i = (uint)b >> 4;
            }
            else if(size<D>() == 2)
            {
                k = skip(data,0);
                i = skip(data,1);
            }
            else if(size<D>() == 4)
            {
                k = skip16(data,0);
                i = skip16(data,2);
            }
            else if(size<D>() == 8)
            {
                k = skip32(data,0);
                i = skip32(data,4);
            }
            return new Domain(k,i);
        }

        [MethodImpl(Inline)]
        public static Projector<S,T> projector<S,T>(Func<S,T> f)
            => new Projector<S,T>(f);

        [MethodImpl(Inline)]
        public static Outcome<uint> project<S,T>(Projector<S,T> p, ReadOnlySpan<S> src, Span<T> dst)
        {
            var count = (uint)min(src.Length,dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = p.F(skip(src,i));
            return count;
        }

        [StructLayout(LayoutKind.Sequential)]
        public readonly struct Domain
        {
            public uint Kind {get;}

            public uint Id {get;}

            [MethodImpl(Inline)]
            public Domain(uint kind, uint id)
            {
                Id = id;
                Kind = kind;
            }
        }

        public readonly struct Domain<D>
            where D : unmanaged
        {
            public D Descriptor {get;}

            [MethodImpl(Inline)]
            public Domain(D d)
            {
                Descriptor = d;
            }

            [MethodImpl(Inline)]
            public static implicit operator Domain(Domain<D> src)
                => untyped(src);
        }

        public readonly struct Source
        {
            public Domain Domain {get;}

            public uint Id {get;}

            [MethodImpl(Inline)]
            public Source(Domain d, uint id)
            {
                Domain = d;
                Id = id;
            }
        }

        public readonly struct Source<T>
        {
            public Domain Domain {get;}

            public T Rep {get;}

            [MethodImpl(Inline)]
            public Source(Domain d, T rep)
            {
                Domain = d;
                Rep = rep;
            }
        }

        public readonly struct Target
        {
            public Domain Domain {get;}

            public uint Id {get;}

            [MethodImpl(Inline)]
            public Target(Domain d, uint id)
            {
                Domain = d;
                Id = id;
            }
        }

        public readonly struct Target<T>
        {
            public Domain Domain {get;}

            public T Rep {get;}

            [MethodImpl(Inline)]
            public Target(Domain d, T rep)
            {
                Domain = d;
                Rep = rep;
            }
        }

        public readonly struct Projection
        {
            public uint Id {get;}

            public Source Source {get;}

            public Target Target {get;}

            [MethodImpl(Inline)]
            public Projection(uint id, Source src, Target dst)
            {
                Id = id;
                Source = src;
                Target = dst;
            }
        }

        public readonly struct Projection<S,T>
        {
            public uint Id {get;}

            public Source<T> Source {get;}

            public Target<T> Target {get;}

            [MethodImpl(Inline)]
            public Projection(uint id, Source<T> src, Target<T> dst)
            {
                Id = id;
                Source = src;
                Target = dst;
            }
        }

        public interface IProjector<S,T>
        {
            Outcome<uint> Project(ReadOnlySpan<S> src, Span<T> dst);
        }

        public readonly struct Projector<S,T> : IProjector<S,T>
        {
            internal readonly Func<S,T> F;

            [MethodImpl(Inline)]
            internal Projector(Func<S,T> f)
            {
                F = f;
            }

            public Outcome<uint> Project(ReadOnlySpan<S> src, Span<T> dst)
                => project(this,src,dst);
        }
    }
}
