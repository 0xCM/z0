//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface IRecordFieldParser
    {        
        /// <summary>
        /// Parses a Y/N literal
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="result">The parse result</param>
        YeaOrNea Parse(string src, out YeaOrNea result);        

        /// <summary>
        /// Parses a string as a string which effects cleansing/trimming/denullifying as necessary
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="result">The parse result</param>
        string Parse(string src, out string result);

        /// <summary>
        /// Parses a numeric field if possible; else sets the result to a default value
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="result">The parse result, if successful, or the supplied default value if not</param>
        /// <param name="default">The parse result value should the parse operation fail</param>
        /// <typeparam name="T">The numeric type</typeparam>
        T Numeric<T>(string src, out T result, T @default = default)     
            where T : unmanaged;        

        /// <summary>
        /// Parses an enumeration literal if possible; else sets the result to a default value
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="result">The parse result, if successful, or the supplied default value if not</param>
        /// <param name="default">The parse result value should the parse operation fail</param>
        /// <typeparam name="E">The enum type</typeparam>
        E Literal<E>(string src, out ParseResult<E> result, E @default = default)
            where E : unmanaged, Enum;        
    }
}