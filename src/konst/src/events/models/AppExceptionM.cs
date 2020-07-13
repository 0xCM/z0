//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;


    public class AppException<M> : Exception, ITextual
        where M : IAppMsg
    {

        public new M Message {get;}

        public AppException() { }
     
        [MethodImpl(Inline)]
        public AppException(M src) 
            : base(src.Format()) 
                => Message = src;

        public string Format()
            => Message.Format();


        public override string ToString()
            => Format();
    }
}