//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public sealed class MklException : AppException
    {
        /// <summary>
        /// Creates an MKL-specific exception
        /// </summary>
        /// <param name="msg">The message text</param>
        /// <param name="caller">The calling member</param>
        /// <param name="file">The file in which invocation occurs</param>
        /// <param name="line">The file line number of invocation</param>
        public static MklException Define(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new MklException(msg,caller,file,line);

        /// <summary>
        /// Creates an MKL-specific exception
        /// </summary>
        /// <param name="msg">The message text</param>
        /// <param name="caller">The calling member</param>
        /// <param name="file">The file in which invocation occurs</param>
        /// <param name="line">The file line number of invocation</param>
        public static MklException Define(int retcode, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => Define($"Call failed with return code {retcode}", caller, file,line);

        /// <summary>
        /// Creates and throws MKL-specific exception
        /// </summary>
        /// <param name="msg">The message text</param>
        /// <param name="caller">The calling member</param>
        /// <param name="file">The file in which invocation occurs</param>
        /// <param name="line">The file line number of invocation</param>
        public static T Throw<T>(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw Define(msg, caller, file,line);

        /// <summary>
        /// Creates and throws MKL-specific exception
        /// </summary>
        /// <param name="retcode">The code returned by MKL indicating failure</param>
        /// <param name="caller">The calling member</param>
        /// <param name="file">The file in which invocation occurs</param>
        /// <param name="line">The file line number of invocation</param>
        public static void Throw(int retcode, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw Define(retcode, caller, file,line);

        MklException(string msg,string caller, string file, int? line)
            : base(AppMsg.define($"{msg} {caller} {file} {line}",LogLevel.Error))
        {

        }
    }
}