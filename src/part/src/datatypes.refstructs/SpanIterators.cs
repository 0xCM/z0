//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct SpanIterators
    {
        const NumericKind Closure = UnsignedInts;

        [Op, Closures(Closure)]
        public static void run<T>(Span<T> src, IOutputIterator<T> dst)
            => new IteratorRelay<T>(dst).Output(src, dst);

        [Op, Closures(Closure)]
        public static void run<T>(Span<T> src, IMutableIterator<T> dst)
            => new IteratorRelay<T>(dst).Edit(src, dst);

        [Op, Closures(Closure)]
        public static void run<T>(Span<T> src, IReadOnlyIterator<T> dst)
            => new IteratorRelay<T>(dst).View(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ViewTrigger<T> trigger<T>(Receiver<T> receiver)
            => new ViewTrigger<T>(receiver);

        [Op, Closures(Closure)]
        public static OutputReceiver<T> receiver<T>(ViewTrigger<T> trigger)
            => OutputReceiver<T>.create(trigger);

        [Op, Closures(Closure)]
        public static void run<T>(Span<T> src, OutputReceiver<T> dst)
        {
            var traverser = new SpanIterator<T>(src);
            while(traverser.NextCell(out dst.Current))
                dst.Trigger.Raise(dst.Current);
        }
    }
}