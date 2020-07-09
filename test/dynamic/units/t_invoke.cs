//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static core;
    using static InvokeApi;

    public readonly struct InvokeApi
    {
        [MethodImpl(Inline), Op]
        public static CallClient client(MemoryAddress @base)
            => new CallClient(@base);

        [MethodImpl(Inline), Op]
        public static CallTarget target(MemoryAddress @base)
            => new CallTarget(@base);            

        [MethodImpl(Inline), Op]
        public static CallClient client(string id, MemoryAddress @base)
            => new CallClient(id, @base);

        [MethodImpl(Inline), Op]
        public static CallTarget target(string id, MemoryAddress @base)
            => new CallTarget(id, @base);            

        [MethodImpl(Inline), Op]
        public static Invocation call(string id, MemoryAddress src, ushort callsite, MemoryAddress dst, string actualId, MemoryAddress actual = default)
            => new Invocation(client(id, src), callsite, target(dst), target(actualId, actual));        
    }
    public class t_invoke : t_dynamic<t_invoke>

    {
        public static Invocation Invoke8u 
            => call("Arrays.empty_8u ", 0x7ff9af96c260, 0x0f, 0x7ff9af96b9c8, "sys.empty_8u", 0x7ff9af971d40);

        public static Invocation Invoke16u 
            => call("Arrays.empty_16u", 0x7ff9af96c2c0, 0x0f, 0x7ff9af96ba08, "sys.empty_16u", 0x7ff9af971db0);

        public static Invocation Invoke16i 
            => call("Arrays.empty_16i",0x7ff9af96c2f0, 0x0f, 0x7ff9af96ba28, "sys.empty_16i", 0x7ff9af971df0);

        public static Invocation Invoke32u 
            => call("Arrays.empty_32u",0x7ff9af96c320, 0x0f, 0x7ff9af96ba48, "sys.empty_32u", 0x7ff9af971e30);

        public static Invocation Invoke64u 
            => call("Arrays.empty_64u", 0x7ff9af96c380, 0x0f, 0x7ff9af96ba88, "sys.empty_64u", 0x7ff9af971eb0);

        static MemoryAddress SiteAddress(Invocation src)
            => src.Client.Base + src.CallSite;

        static MemoryAddress TargetAddress(Invocation src)
            => src.CalledTarget.Base;

        public void print_calls()
        {

            var samples = core.span(Invoke8u, Invoke16u, Invoke16i, Invoke32u, Invoke64u);
            for(var i=0u; i<samples.Length; i++)
            {
                ref readonly var sample = ref skip(samples,i);
                var site = SiteAddress(sample);
                var target = TargetAddress(sample);
                var offset = (site - target).Location;
                var delta = (sample.ActualTaget.Base - site).Location;
                var actual = sample.ActualTaget.Id;

                var client_field = text.concat(sample.Client.Id, text.embrace(site.Format()));
                

                Trace($"{client_field} | {target} | {offset} | {actual} | {delta}");
            }
        }

    }
}