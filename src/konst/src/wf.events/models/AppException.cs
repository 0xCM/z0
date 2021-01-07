//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class AppException : Exception
    {
        public new IAppMsg Message {get;}

        [MethodImpl(Inline)]
        public static AppException Define(IAppMsg msg)
            => new AppException(msg);

        public static AppException Define(object reason, string caller, string file, int? line)
            => new AppException(reason?.ToString(), caller, file, line);

        public AppException() { }

        [MethodImpl(Inline)]
        public AppException(IAppMsg src)
            : base(src.Format())
                => Message = src;

        [MethodImpl(Inline)]
        public AppException(string msg, string caller, string file, int? line)
            : base(msg)
        {
            Message = AppMsg.error(msg, caller, file, line);
        }

        public override string ToString()
            => Message.Format();
    }
}