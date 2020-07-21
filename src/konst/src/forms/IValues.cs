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
    using static Valued;

    class Valued
    {
        public const string DefaultSep = " | ";

        public static StringBuilder Text() 
            => new StringBuilder();
    }

    public interface IValues<F,T> : ITextual, INullity, INullary<F>
        where T : IValued<T>, new()
        where F : IValues<F,T>, new()
    {
        T[] Data {get;}

        ref readonly T this[int index] => ref Data[index];

        bool INullity.IsEmpty => Data is null || Data.Length == 0;

        [MethodImpl(Inline)]
        string FormatDelimiter(int index)
            => index != 0 ? DefaultSep : string.Empty;

        [MethodImpl(Inline)]
        string FormatItem(int index, string sep)
            => FormatDelimiter(index) + this[index].Format();
        
        string Format(string sep)        
        {
            if(Data is null)
                return string.Empty;

            var dst = Text();
            for(var i=0; i<Data.Length; i++)
                dst.Append(FormatItem(i, sep));
            return dst.ToString();
        }
    }
}