//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct IteratorRelay<T> : IIteratorRelay<IteratorRelay<T>,T>
    {
        readonly IMutableIterator<T> EditTarget;

        readonly IReadOnlyIterator<T> ViewTarget;

        readonly IOutputIterator<T> OutTarget;

        readonly IEnumerableTarget<T> EnumerableTarget;

        internal T Current;

        internal IteratorRelay(IMutableIterator<T> target)
        {
            EditTarget = target;
            ViewTarget = default;
            OutTarget = default;
            Current = default;
            EnumerableTarget = default;
        }

        internal IteratorRelay(IReadOnlyIterator<T> target)
        {
            EditTarget = default;
            ViewTarget = target;
            OutTarget = default;
            Current = default;
            EnumerableTarget = default;
        }

        internal IteratorRelay(IOutputIterator<T> target)
        {
            EditTarget = default;
            ViewTarget = default;
            OutTarget = target;
            Current = default;
            EnumerableTarget = default;
        }

        internal IteratorRelay(EnumerableTarget<T> target)
        {
            EditTarget = default;
            ViewTarget = default;
            OutTarget = default;
            Current = default;
            EnumerableTarget = target;
        }

        [MethodImpl(Inline)]
        void Enumerate(Span<T> src)
        {
            var iterator = new SpanIterator<T>(src);
            while(iterator.NextEdit(this)){ }
        }

        [MethodImpl(Inline)]
        internal void Edit(Span<T> src, IMutableIterator<T> dst)
        {
            var iterator = new SpanIterator<T>(src);
            while(iterator.NextEdit(this)){}
        }

        [MethodImpl(Inline)]
        internal void View(Span<T> src, IReadOnlyIterator<T> dst)
        {
            var iterator = new SpanIterator<T>(src);
            while(iterator.NextView(this)) { }
        }

        [MethodImpl(Inline)]
        internal void Output(Span<T> src, IOutputIterator<T> dst)
        {
            var iterator = new SpanIterator<T>(src);
            while(iterator.NextOutput(this)){}
        }

        [MethodImpl(Inline)]
        public void Edit(ref T dst, out bool success)
        {
            EditTarget.Edit(ref dst, out success);
            Current = dst;
        }

        [MethodImpl(Inline)]
        public void Next(out T dst, out bool success)
        {
            OutTarget.Next(out dst, out success);
            Current = dst;
        }

        [MethodImpl(Inline)]
        public void View(in T dst, out bool success)
        {
            ViewTarget.View(dst, out success);
            Current = dst;
        }
    }
}