//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public interface ISpanPipe<T> : IPipe
        where T : struct
    {   
        ref T Flow(ref T src);

        Span<T> Flow(Span<T> src)
        {
            for(var i=0; i<src.Length; i++)
                Flow(ref seek(src, i));
            return src;
        }

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
        {            
            ref T value = ref Unsafe.As<object,T>(ref src);
            return Flow(ref value);
        }
    }

    /// <summary>
    /// Characterizes an orchestrator that coordinates data transmission
    /// </summary>
    public interface ISpanFlow<T> : IFlow
        where T : struct
    {
        [MethodImpl(Inline)]
        ref T Flow(ref T src, ISpanPipe<T> dst)
            => ref dst.Flow(ref src);            

        [MethodImpl(Inline)]
        Span<T> Flow(Span<T> src, ISpanPipe<T> dst)
            => dst.Flow(src);

        Span<T> Flow(ISpanSource<T> source, ISpanPipe<T> pipe)
            => Flow(source.Data, pipe);
    }

    public interface ISpanSource<T> : IDataProvider
    {
        new Span<T> Data {get;}   

        IEnumerable<object> IDataProvider.Data
            => Data.ToArray().Cast<object>();
    }

    readonly struct SpanPipe<T> : ISpanPipe<T>
        where T : struct
    {
        readonly ValueEditor<T> Editor;
        
        [MethodImpl(Inline)]
        public SpanPipe(ValueEditor<T> editor)
            => Editor = editor;

        [MethodImpl(Inline)]
        public ref T Flow(ref T src)
            => ref Editor(ref src);
    }

    readonly struct SpanFlow<T> : ISpanFlow<T>
        where T : struct
    {
        

    }
}