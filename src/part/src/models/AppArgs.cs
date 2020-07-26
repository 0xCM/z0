//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    public readonly struct AppArg
    {        
        public static AppArg parse(string src)
        {
            var content = src.Trim();
            if(!String.IsNullOrWhiteSpace(content))
            {
                if(src[0] == '/')
                {
                    var parts = src.Substring(1).Split(':', StringSplitOptions.RemoveEmptyEntries);

                    if(parts.Length == 2)
                        return new AppArg(parts[0], parts[1]);
                    else if(parts.Length == 0)
                        return Empty;
                    else
                    {
                        var dst = parts[0];
                        for(var i=1; i<parts.Length; i++)
                            dst += $" {parts[i]}";
                        return new AppArg(string.Empty, dst);
                    }
                }
                else
                    return new AppArg(string.Empty, src);
            }

            return Empty;
        }
        
        public AppArg(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public readonly string Name;

        public readonly string Value;

        public bool IsEmpty => string.IsNullOrWhiteSpace(Value);

        public bool IsNonEmpty => !IsEmpty;
        public static AppArg Empty 
            => new AppArg(string.Empty, string.Empty);

    }
    
    public readonly struct AppArgs
    {
        public static AppArgs Empty => new AppArgs(new AppArg[0]{});
        
        public static AppArgs parse(string[] src)
        {
            if(src.Length != 0)
            {
                var dst = new List<AppArg>();
                foreach(var item in src)
                {
                    var parsed= AppArg.parse(item);
                    if(parsed.IsNonEmpty)
                        dst.Add(parsed);
                }
                
                if(dst.Count != 0)
                    return new AppArgs(dst.ToArray());
            }
            return Empty;
        }
        public readonly AppArg[] Data;

        public AppArgs(AppArg[] src)
        {
            Data = src;
        }
    }
    
    public readonly struct AppArg<T>
    {

        public AppArg(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public readonly string Name;

        public readonly T Value;
    }
}