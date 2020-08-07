//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Data.Dataset;

    public interface IDatasetFormatter<F> : IDatasetFormatter
        where F : unmanaged, Enum
    {
        string IDatasetFormatter.HeaderText
            => header<F>().Render(Delimiter);

        string[] IDatasetFormatter.Labels
            => labels<F>();    

        int Index(F field)
            => index(field);

        int Width(F field)
            => width(field);            

        void Append(F f, object content)   
        {
            State.Append(render(content).PadRight(width(f)));
        }

        void Delimit(F f, object content)
        {            
            State.Append(text.rspace(Delimiter));            
            State.Append(render(content).PadRight(width(f)));
        }

        void IDatasetFormatter.EmitHeader(bool eol)
        {
            var header = header<F>();    
            for(var i=0; i<header.Fields.Length; i++)
            {   
                if(i == 0)
                    Append(header.Fields[i], header.Labels[i]);
                else
                    Delimit(header.Fields[i], header.Labels[i]);
            }

            if(eol)
                State.Append(Eol);
        }

        void Append<T>(F f, T content)
            where T : ITextual
        {
            State.Append(render(content).PadRight(width(f)));
        }

        void Delimit<T>(F f, T content)
            where T : ITextual
        {            
            State.Append(text.rspace(Delimiter));            
            State.Append(render(content).PadRight(width(f)));
        }

        void DelimitSome<T>(F f, T src)
            where T : unmanaged, Enum              
                => DelimitField(f, src.IsSome()  ? src.ToString() : text.Empty, Delimiter);        

        void DelimitField(F f, object content, char delimiter)
        {            
            State.Append(text.rspace(delimiter));            
            State.Append(render(content).PadRight(width(f)));
        }
    }
}