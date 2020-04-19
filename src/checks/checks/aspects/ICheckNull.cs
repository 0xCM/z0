//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Seed;
    using static AppErrorMsg;

    public readonly struct CheckNull : ICheckNull
    {

    }
    
    public interface ICheckNull : IValidator
    {
        /// <summary>
        /// Asserts the pointer is not null
        /// </summary>
        /// <param name="p">The pointer to check</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        unsafe void notnull(void* p, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null).OnNone(() => throw new ArgumentNullException(AppMsg.Define($"Pointer was null", AppMsgKind.Error, caller,file,line).ToString()));

        void notnull<T>(T src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : class
        {
            if(src is null)    
                throw new ArgumentNullException(AppMsg.Define($"Argument was null", AppMsgKind.Error, caller,file,line).ToString());                
        }
    }
}