//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public interface IChannel1x1<T>
    {
        void Send(T x0, out T y0);
    }

    public interface IChannel1x1<F,T> : IChannel1x1<T>
        where F : unmanaged, IChannel1x1<F,T>
        where T : unmanaged
    {

    }

    public interface IChannel2x1<T>
        where T : unmanaged
    {
        void Send(T x0, T x1, out T y0);
    }

    public interface IChannel2x1<F,T> : IChannel2x1<T>
        where F : unmanaged, IChannel2x1<F,T>
        where T : unmanaged
    {

    }

    public interface IChannel2x2<T>
        where T : unmanaged
    {
        void Send(T x0, T x1, out T y0, out T y1);
    }

    public interface IChannel2x2<C,T> : IChannel2x2<T>
        where T : unmanaged
        where C : unmanaged, IChannel2x2<C,T>
    {
    }

    public readonly struct LogicChannels
    {
        public readonly struct Not<T> : IChannel1x1<Not<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Send(T x0, out T y0)
                => y0 = gmath.not(x0);
        }

        public readonly struct And<T> : IChannel2x1<And<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Send(T x0, T x1, out T y0)
                => y0 = gmath.and(x0,x1);
        }

        public readonly struct Or<T> : IChannel2x1<Or<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Send(T x0, T x1, out T y0)
                => y0 = gmath.or(x0,x1);
        }

        public readonly struct Xor<T> : IChannel2x1<Xor<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Send(T x0, T x1, out T y0)
                => y0 = gmath.xor(x0,x1);
        }

        public readonly struct Xnor<T> : IChannel2x1<Xnor<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Send(T x0, T x1, out T y0)
                => y0 = gmath.xnor(x0,x1);
        }

        public readonly struct Nand<T> : IChannel2x1<Nand<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Send(T x0, T x1, out T y0)
                => y0 = gmath.nand(x0,x1);
        }
    }

    public readonly partial struct Networks
    {
        public static SortingNetwork<T> sorting<T>()
            where T : unmanaged
        {
            var channels = alloc<Comparator<T>>(6);
            var i=0;
            seek(channels,i++) = new Comparator<T>();
            seek(channels,i++) = new Comparator<T>();
            seek(channels,i++) = new Comparator<T>();
            seek(channels,i++) = new Comparator<T>();
            seek(channels,i++) = new Comparator<T>();
            seek(channels,i++) = new Comparator<T>();
            return new SortingNetwork<T>(channels);
        }
    }

    public readonly struct Comparator<T> : IChannel2x2<Comparator<T>,T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public void Send(T x0, T x1, out T y0, out T y1)
        {
            y0 = gmath.min(x0,x1);
            y1 = gmath.max(x0,x1);
        }
    }

    public readonly struct SortingNetwork<T>
        where T : unmanaged
    {
        readonly Index<Comparator<T>> Channels;

        [MethodImpl(Inline)]
        internal SortingNetwork(Comparator<T>[] channels)
        {
            Channels = channels;
        }

        [MethodImpl(Inline)]
        ref readonly Comparator<T> Component(uint index)
            => ref Channels[index];

        ref readonly Comparator<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Component(index);
        }

        [MethodImpl(Inline)]
        public void Send(T x0, T x1, T x2, T x3, out T y0, out T y1, out T y2, out T y3)
        {
            ref readonly var a = ref this[0];
            ref readonly var b = ref this[1];
            ref readonly var c = ref this[2];
            ref readonly var d = ref this[3];
            ref readonly var e = ref this[4];
            a.Send(x0, x1, out y0, out y1);
            b.Send(x2, x3, out y2, out y3);
            c.Send(y0, y2, out y0, out y2);
            d.Send(y1, y3, out y1, out y3);
            e.Send(y1, y2, out y1, out y2);
        }
    }
}