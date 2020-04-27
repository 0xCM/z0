//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;
    using static Memories;

    /// <summary>
    /// Extracts operations from an api host
    /// </summary>
    public readonly struct HostCodeExtractor : IHostCodeExtractor
    {
        public IContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IHostCodeExtractor Create(IContext context, int bufferlen)
            => new HostCodeExtractor(context,bufferlen);
            
        [MethodImpl(Inline)]
        HostCodeExtractor(IContext context, int bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen;
        }

        /// <summary>
        /// Extracts encoded content that defines executable code for a located member
        /// </summary>
        /// <param name="src">The source member</param>
        public MemberExtract Extract(in Member src)
        {
            Span<byte> buffer = stackalloc byte[BufferLength];
            var reader = Context.MemoryReader();
            return Extract(src, reader, buffer);
        }

        public MemberExtract[] Extract(Member[] members)
        {
            var dst = new MemberExtract[members.Length];
            Span<byte> buffer = stackalloc byte[BufferLength];            
            var reader = Context.MemoryReader();
            for(var i=0; i<members.Length; i++)
                dst[i] = Extract(members[i], reader, buffer);
            return dst;
        }

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        public MemberExtract[] Extract(IApiHost src)
        {
            var locator = Context.MemberLocator();
            var members = locator.Located(src).ToArray();
            return Extract(members);
        }

        [MethodImpl(Inline)]
        MemberExtract Extract(in Member src, IMemoryReader reader, Span<byte> buffer)
        {
            buffer.Clear();                
            var length = reader.Read(src.Address, buffer);
            var data = LocatedCode.Define(src.Address, buffer.Slice(0,length).ToArray());
            return MemberExtract.Define(src, data);
        }
    }
}