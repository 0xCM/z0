//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public unsafe readonly struct NullArgMsg
    {        
        [MethodImpl(Inline)]
        public static string format(string caller, string file, int? line)
            => text.concat(MsgText, " | ", AppMsg.Source(caller,file,line));
                
        public const string MsgText = "A null argument was provided";        

        public static Func<string> Formatter 
            => () => MsgText;

        public static Func<string, string, int?, string> Sourced 
            => format;
    }
    
    partial class AppErrors
    {        
        public static Func<string, string, int?, string> NullArgFormatter
            => NullArgMsg.Sourced;
        
        [MethodImpl(Inline), Op]
        public static string NullArg()
             => NullArgMsg.MsgText;

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static string NullArg(string caller, string file, int? line)
             => NullArgMsg.Sourced(caller,file,line);             
    }    
}