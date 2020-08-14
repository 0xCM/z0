//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static RenderPatterns;
    using static z;
        
    [ApiHost]
    public readonly partial struct Render
    {
        public static string textual<T>(ReadOnlySpan<T> src, string delimiter)            
            where T : ITextual
                => concat(items(src),delimiter);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(T content)        
            => text.format(Slot0, content);

        [MethodImpl(Inline)]
        public static string format<T0,T1>(T0 x0, T1 x1)        
            where T0 : ITextual
            where T1 : ITextual
                => string.Format(PSx2, x0.Format(),  x1.Format());
                
        [MethodImpl(Inline)]
        public static string format<T0,T1,T2>(T0 x0, T1 x1, T2 x2)        
            where T0 : ITextual
            where T1 : ITextual
            where T2 : ITextual
                => string.Format(PSx3, x0.Format(), x1.Format(), x2.Format());                

        [MethodImpl(Inline)]
        public static string format<T0,T1,T2,T3>(T0 x0, T1 x1, T2 x2, T3 x3)        
            where T0 : ITextual
            where T1 : ITextual
            where T2 : ITextual
            where T3 : ITextual
                => string.Format(PSx4, x0.Format(), x1.Format(), x2.Format(), x3.Format());

        [MethodImpl(Inline)]
        public static string format<T0,T1,T2,T3,T4>(T0 x0, T1 x1, T2 x2, T3 x3,T4 x4)        
            where T0 : ITextual
            where T1 : ITextual
            where T2 : ITextual
            where T3 : ITextual
            where T4 : ITextual
                => string.Format(PSx5, x0.Format(), x1.Format(), x2.Format(), x3.Format(), x0.Format());

        public const MessageFlair Error = MessageFlair.Red;

        public const MessageFlair Created = MessageFlair.Gray;

        public const MessageFlair Running = MessageFlair.Magenta;

        public const MessageFlair Ran = MessageFlair.Cyan;

        public const MessageFlair Finished = MessageFlair.Gray;

        public const MessageFlair Status = MessageFlair.Green;

        public const MessageFlair Initializing = MessageFlair.Gray;

        public const MessageFlair Initialized = MessageFlair.Gray;                
    }
}