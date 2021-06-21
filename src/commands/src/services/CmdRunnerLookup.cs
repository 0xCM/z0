//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public class CmdRunnerLookup
    {
        public static CmdRunnerLookup create()
            => new CmdRunnerLookup();

        readonly Dictionary<string,MethodInfo> Data;

        KeyValuePairs<string,MethodInfo> Pairs;

        bool Sealed;

        CmdRunnerLookup()
        {
            Data = new();
            Pairs = KeyValuePairs<string,MethodInfo>.Empty;
        }

        public bool Add(string spec, MethodInfo runner)
        {
            if(Sealed)
                return false;
            else
                return Data.TryAdd(spec, runner);
        }

        public bool Find(string spec, out MethodInfo runner)
        {
            runner = default;
            if(Sealed)
                return false;
            else
                return Data.TryGetValue(spec, out runner);
        }

        public CmdRunnerLookup Seal()
        {
            Pairs = Data.ToKVPairs();
            Sealed = true;
            return this;
        }

        public ReadOnlySpan<string> Specs
        {
            [MethodImpl(Inline)]
            get => Pairs.Keys;
        }

        public ReadOnlySpan<MethodInfo> Runners
        {
            [MethodImpl(Inline)]
            get => Pairs.Values;
        }
    }
}