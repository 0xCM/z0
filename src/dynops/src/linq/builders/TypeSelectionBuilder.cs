//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

   
    public class TypeSelectionBuilder<TResult>
    {
        public static implicit operator Selector<Type, object, TResult>(TypeSelectionBuilder<TResult> builder)
            => builder.Finish();

        Dictionary<Type, Func<object, TResult>> functions { get; } 
            = new Dictionary<Type, Func<object, TResult>>();

        readonly object value;

        public TypeSelectionBuilder()
        {

        }

        public TypeSelectionBuilder(object value)
        {
            this.value = value;
        }

        public TypeSelectionBuilder<TResult> When<T>(Func<T, TResult> f)
        {
            functions[typeof(T)] = x => f((T)x);
            return this;
        }

        public Selector<Type, object, TResult> Finish()
            => new Selector<Type, object, TResult>(functions);

        public TResult Eval(object value)
            => Finish().Select(value.GetType(), value);

        public TResult Eval()
            => Finish().Select(value.GetType(), value);
    }

}