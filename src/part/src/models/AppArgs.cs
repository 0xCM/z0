//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Part;

    public readonly struct AppArgs
    {
        public readonly AppArg[] Parsed;

        [MethodImpl(Inline)]
        public AppArgs(AppArg[] src)
            => Parsed = src;

        [MethodImpl(Inline)]
        public static implicit operator AppArgs(AppArg[] src)
            => new AppArgs(src);
        
        const string Missing = "";

        const StringSplitOptions RemoveEmpties = StringSplitOptions.RemoveEmptyEntries;

        const StringComparison Compare = StringComparison.InvariantCultureIgnoreCase;

        public static AppArg parse(string src, char flag = '/', char argspec = '?')
        {
            var content = src.Trim();
            if(!String.IsNullOrWhiteSpace(content))
            {
                if(src[0] == flag)
                {
                    var parts = src.Substring(1).Split(argspec, RemoveEmpties);

                    if(parts.Length == 2)
                        return new AppArg(parts[0], parts[1]);
                    else if(parts.Length == 0)
                        return EmptyArg;
                    else
                    {
                        var dst = parts[0];
                        for(var i=1; i<parts.Length; i++)
                            dst += string.Format(" {0}", parts[i]);
                        return (Missing, dst);
                    }
                }
                else
                    return (Missing, src);
            }

            return EmptyArg;
        }
        
        public static AppArgs parse(string[] src)
        {
            if(src.Length != 0)
            {
                var dst = new List<AppArg>();
                foreach(var item in src)
                {
                    var parsed= parse(item);
                    if(parsed.IsNonEmpty)
                        dst.Add(parsed);
                }
                
                if(dst.Count != 0)
                    return dst.ToArray();
            }
            return Empty;
        }
                
        public AppArg this[string name]
        {
            get
            {
                for(var i=0; i<Parsed.Length; i++)
                {
                    ref readonly var arg = ref Parsed[i];
                    if(string.Equals(arg.Name, name, Compare))
                        return arg;
                }
                return AppArg.Empty;
            }
        }

        public static AppArgs Empty 
            => new AppArgs(new AppArg[0]{});
        
        public static AppArg EmptyArg 
            => AppArg.Empty;        
    }
}