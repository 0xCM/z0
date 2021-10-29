//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct flows
    {
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