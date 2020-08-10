//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using static Konst;
    using static Pow2x32;

    public enum IlDasmFlag
    {
        /// <summary> Shows actual bytes, in hexadecimal format, as instruction comments. </summary>
        Bytes , 
        
        /// <summary> Produces custom attribute blobs in verbal form. The default is binary form. </summary>
        CaVerbal,                    
        
        /// <summary> Includes references to original source lines. </summary>
        Linenum ,                   

        /// <summary> Suppresses the disassembly progress indicator pop-up window. </summary>
        NoBar,                       

        /// <summary> Suppresses the output of custom attributes. </summary>
        NoCa,                        

        /// <summary> 
        /// Displays metadata the way it appears to managed code, instead of the way it appears 
        /// in the native Windows Runtime. If PEfilename is not a Windows metadata ( .winmd ) file, this 
        /// option has no effect. See .NET Framework Support for Windows Store Apps and Windows Runtime.
        /// </summary>
        Project,                     

        /// <summary> Disassembles only public types and members. Equivalent to /visibility:PUB 
        PubOnly,                     

        /// <summary> Includes all names in single quotes.
        QuoteAllNames,                

        /// <summary> Shows exception handling clauses in raw form.
        RawEH,                       

        /// <summary> Shows original source lines as comments.
        Source,                      

        /// <summary> Shows metadata tokens of classes and members.
        Tokens,                      

        /// <summary> 
        /// Disassembles only types or members with the specified visibility. 
        /// The following are valid values for vis: 
        /// PUB — Public 
        /// PRI — Private 
        /// FAM — Family 
        /// ASM — Assembly 
        /// FAA — Family and Assembly 
        /// FOA — Family or Assembly 
        /// PSC — Private Scope
        /// </summary>
        Visibility, 
    }
}