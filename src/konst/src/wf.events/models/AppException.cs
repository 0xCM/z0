//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class AppException : Exception
    {
        public new IAppMsg Message {get;}

        [MethodImpl(Inline)]
        public static AppException Define(IAppMsg msg)
            => new AppException(msg);

        public static AppException Define(object reason, string caller, string file, int? line)
            => Define(AppMsg.define($"{reason?.ToString()} {caller} {file} {line}", LogLevel.Error));

        public AppException() { }

        [MethodImpl(Inline)]
        public AppException(IAppMsg src)
            : base(src.Format())
                => Message = src;

        public override string ToString()
            => Message.Format();
    }
}