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

    public interface IValueFormatter<T> : IFormatter<T>
        where T : struct
    {
        string Format(in T src);

        string IFormatter<T>.Format(T src)
            => Format(src);     

        string HeaderText {get;}               
    }

    public interface IValueFormatter<F,T> : IValueFormatter<T>
        where F : unmanaged, Enum
        where T : struct
    {

        void Format(in T src, IDatasetFormatter<F> dst);

        void Format(in T src, IDatasetFormatter<F> dst, bool eol)
        {
            Format(src, dst);
            if(eol)
                dst.EmitEol();
        }
        
        string IValueFormatter<T>.Format(in T src)
        {
            var dst = Dataset.formatter<F>();
            Format(src, dst);
            return dst.Render();
        }

        string IValueFormatter<T>.HeaderText
            => Dataset.formatter<F>().HeaderText;    
    }

    public readonly struct ValueFormatter
    {
        [MethodImpl(Inline)]
        public static ValueFormatter<F,T> from<F,T>(IValueFormatter<F,T> src)
            where F : unmanaged, Enum
            where T : struct
                => new ValueFormatter<F,T>(src);
    }

    public readonly struct ValueFormatter<F,T>
        where F : unmanaged, Enum
        where T : struct
    {
        readonly IValueFormatter<F,T> Formatter;        
                
        [MethodImpl(Inline)]
        public ValueFormatter(IValueFormatter<F,T> formatter)
        {
            Formatter = formatter;
        }
    
        [MethodImpl(Inline)]
        public string Format(in T src)
            => Formatter.Format(src);

        public string HeaderText
            => Dataset.header<F>().Render();
    }
}