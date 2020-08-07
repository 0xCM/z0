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
    
    public interface IDatasetFormatter : ITextual
    {
        StringBuilder State {get;}

        string HeaderText {get;}

        string[] Labels {get;}

        void EmitHeader(bool eol = true);
        
        char Delimiter 
            => FieldDelimiter;

        string Render(bool reset = true)
        {            
            var result = State.ToString();
            if(reset)
                State.Clear();
            return result;
        }            

        void Reset() 
            => State.Clear();        

        string ITextual.Format()
            => State.ToString();

        void EmitEol()
        {
            State.Append(Eol);
        }
    }
}