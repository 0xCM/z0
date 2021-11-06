//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct flows
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a <see cref='Flow{S,T}'/> from a specified source to a specified target;
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Flow<S,T> flow<S,T>(in S src, in T dst)
            where S : IChannel
            where T : IChannel
                => new Flow<S,T>(src,dst);

        [MethodImpl(Inline)]
        public static Flow<K,S,T> flow<K,S,T>(K kind, in S src, in T dst)
            where K : unmanaged
            where S : IChannel
            where T : IChannel
                => new Flow<K,S,T>(kind,src,dst);

        [MethodImpl(Inline), Op]
        public static Channel channel(uint cells, uint width, Mask mask = default)
            => new Channel(cells, width, mask);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Channel<T> channel<T>(uint cells, Mask mask = default)
            where T : unmanaged, ITypeWidth
                => new Channel<T>(cells,mask);

        [MethodImpl(Inline)]
        public static Channel<N,W> channel<N,W>(N n = default, W w = default)
            where W : unmanaged, ITypeWidth
            where N : unmanaged, ITypeNat
                => new Channel<N,W>();

        [MethodImpl(Inline)]
        public static Channel<N,W> channel<N,W>(Mask mask, N n = default, W w = default)
            where W : unmanaged, ITypeWidth
            where N : unmanaged, ITypeNat
                => new Channel<N,W>(mask);

        [MethodImpl(Inline), Op]
        public static MergeMask mmask(ulong value)
            => new MergeMask(value);

        [MethodImpl(Inline)]
        public static Fiber<T> fiber<T>(T channel, uint cell = 0, ushort offset = 0, byte width = 0)
            where T : unmanaged,IChannel
                => new Fiber<T>(channel,cell,offset,width);

        [MethodImpl(Inline), Op]
        public static Fiber fiber(Channel channel, uint cell = 0, ushort offset = 0, byte width = 0)
            => new Fiber(channel,cell,offset,width);

        [MethodImpl(Inline), Op]
        public static ZeroMask zmask(ulong value)
            => new ZeroMask(value);

         public static string syntax<S,T>(Flow<S,T> flow)
            where S : IChannel
            where T : IChannel
        {
            const string Pattern = "{0}:{1} -> {4}:{5}";
            return string.Format(Pattern, flow.Source, typeof(S).Name, flow.Target, typeof(T).Name);
        }

        public static string syntax<K,S,T>(Flow<K,S,T> flow)
            where K : unmanaged
            where S : IChannel
            where T : IChannel
        {
            const string Pattern = "{0}:{1} |{2}:{3}> {4}:{5}";
            return string.Format(Pattern, flow.Source, typeof(S).Name, flow.Kind, typeof(K).Name, flow.Target, typeof(T).Name);
        }

        internal static string format(ZeroMask src)
            => string.Format("z{{0}}", src.Value.FormatBits());

        internal static string format(MergeMask src)
            => string.Format("k{{0}}", src.Value.FormatBits());

        internal static string format(Mask src)
        {
            if(src.IsEmpty)
                return EmptyString;
            else
            {
                if(src.Kind == MaskKind.Zero)
                    return string.Format("z{{0}}", src.Value.FormatBits());
                else
                    return string.Format("k{{0}}", src.Value.FormatBits());
            }
        }

        internal static string format(Channel src)
        {
            if(src.Mask.IsEmpty)
                return string.Format("{0}x{1}", src.CellCount, src.CellWidth);
            else
                return string.Format("{0}x{1} {2}", src.CellCount, src.CellWidth, format(src.Mask));
        }

        internal static string format<K,S,T>(in Flow<K,S,T> flow)
            where K : unmanaged
            where S : IChannel
            where T : IChannel
                => string.Format("{0} |{1}> {2}", flow.Source, flow.Kind, flow.Target);

        internal static RenderPattern<S,T> RenderFlow<S,T>() => "{0} -> {1}";

        internal static RenderPattern<T,T> RenderFlow<T>() => RenderFlow<T,T>();

        internal static string format<S,T>(in Flow<S,T> flow)
            where S : IChannel
            where T : IChannel
                => RenderFlow<S,T>().Format(flow.Source, flow.Target);
    }
}