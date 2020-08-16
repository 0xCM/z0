//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Calls
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

        [MethodImpl(Inline), Op]
        public static Invocation call(MemoryAddress src, ushort callsite, MemoryAddress dst, MemoryAddress actual = default)
            => new Invocation(client(src), callsite, target(dst), target(actual));

        /// <summary>
        /// Computes the call-site offset relative to the base address of the client
        /// </summary>
        /// <param name="src">The invocation</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress offset(Invocation src)
            => src.Client.Base + src.CallSite;
 
        public static string format(Invocation src)
        {
            var site = Calls.offset(src);
            var target =  src.CalledTarget.Base;
            var offset = (site - target).Location;
            var delta = (src.ActualTarget.Base - site).Location;
            var actual = src.ActualTarget.Id;
            var client_field = text.concat(src.Client.Id, text.embrace(site.Format()));                
            return $"{client_field} | {target} | {offset} | {actual} | {delta}";
        }        
    }
}