//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Extracts operations from an api host
    /// </summary>
    readonly struct HostOpExtractor : IHostOpExtractor
    {
        public IContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IHostOpExtractor New(IContext context, int bufferlen)
            => new HostOpExtractor(context,bufferlen);
            
        [MethodImpl(Inline)]
        HostOpExtractor(IContext context, int bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen;
        }

        /// <summary>
        /// Extracts encoded content that defines executable code for a located member
        /// </summary>
        /// <param name="src">The source member</param>
        public MemberExtract Extract(ApiLocatedMember src)
        {
            Span<byte> buffer = stackalloc byte[BufferLength];
            var reader = Context.MemoryReader();
            return Extract(src, reader, buffer);
        }

        public MemberExtract[] Extract(ApiLocatedMember[] members)
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
        public MemberExtract[] Extract(ApiHost src)
        {
            var locator = Context.MemberLocator();
            var members = locator.Located(src).ToArray();
            return Extract(members);
        }

        [MethodImpl(Inline)]
        MemberExtract Extract(ApiLocatedMember src, IMemoryReader reader,  Span<byte> buffer)
        {
            buffer.Clear();                
            var length = reader.Read(src.Address, BufferLength, buffer);
            var data = MemoryExtract.Define(src.Address, buffer.Slice(0,length).ToArray());
            return MemberExtract.Define(src, data);
        }
    }
}