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

    public readonly struct WfArgs
    {
        public readonly WfArg[] Parsed;

        [MethodImpl(Inline)]
        public WfArgs(WfArg[] src)
            => Parsed = src;

        [MethodImpl(Inline)]
        public static implicit operator WfArgs(WfArg[] src)
            => new WfArgs(src);

        const string Missing = "";

        const StringSplitOptions RemoveEmpties = StringSplitOptions.RemoveEmptyEntries;

        const StringComparison Compare = StringComparison.InvariantCultureIgnoreCase;

        public static WfArg parse(string src, char flag = '/', char argspec = '?')
        {
            var content = src.Trim();
            if(!String.IsNullOrWhiteSpace(content))
            {
                if(src[0] == flag)
                {
                    var parts = src.Substring(1).Split(argspec, RemoveEmpties);

                    if(parts.Length == 2)
                        return new WfArg(parts[0], parts[1]);
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

        public static WfArgs parse(string[] src)
        {
            if(src.Length != 0)
            {
                var dst = new List<WfArg>();
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

        public WfArg this[string name]
        {
            get
            {
                for(var i=0; i<Parsed.Length; i++)
                {
                    ref readonly var arg = ref Parsed[i];
                    if(string.Equals(arg.Name, name, Compare))
                        return arg;
                }
                return WfArg.Empty;
            }
        }

        public static WfArgs Empty
            => new WfArgs(new WfArg[0]{});

        public static WfArg EmptyArg
            => WfArg.Empty;
    }
}