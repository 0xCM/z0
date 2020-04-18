//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;    

    public class SelectionBuilder<T,X,R>
    {        
        readonly Dictionary<T,Func<X,R>> functions;
        
        readonly T t;
        
        readonly X x;

        [MethodImpl(Inline)]
        public static implicit operator Selector<T,X,R>(SelectionBuilder<T,X,R> builder)
            => builder.Finish();

        [MethodImpl(Inline)]
        public SelectionBuilder()
        {
            functions = new Dictionary<T,Func<X,R>>();
        }

        public SelectionBuilder(T t, X x)
            : this()
        {
            this.t = t;
            this.x = x;
        }

        [MethodImpl(Inline)]
        public SelectionBuilder<T,X,R> When(T t, Func<X,R> f)
        {
            functions[t] = f;
            return this;
        }

        [MethodImpl(Inline)]
        public Selector<T,X,R> Finish()
            => new Selector<T,X,R>(functions);

        [MethodImpl(Inline)]
        public R Eval(T t, X x)
            => Finish().Select(t, x);

        public R Eval() => Finish().Select(t, x);
    }

    public class SelectionBuilder<T,R>
    {
        readonly Dictionary<T,Func<R>> functions;
        
        readonly T t;

        [MethodImpl(Inline)]
        public static implicit operator Selector<T,R>(SelectionBuilder<T,R> builder) 
            => builder.Finish();

        [MethodImpl(Inline)]
        public SelectionBuilder()
        {
            functions = new Dictionary<T,Func<R>>();
        }

        [MethodImpl(Inline)]
        public SelectionBuilder(T t)
            : this()
        {
            this.t = t;
        }

        [MethodImpl(Inline)]
        public SelectionBuilder<T,R> When(T t, Func<R> f)
        {
            functions[t] = f;
            return this;
        }

        [MethodImpl(Inline)]
        public Selector<T,R> Finish()
            => new Selector<T,R>(functions);

        [MethodImpl(Inline)]
        public R Eval(T t)
            => Finish().Select(t);

        [MethodImpl(Inline)]
        public R Eval()
            => Finish().Select(t);
    }
}