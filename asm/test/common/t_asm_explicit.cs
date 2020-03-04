//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class t_asm_explicit<E> : UnitTest<E>, IExplicitTest
        where E : t_asm_explicit<E>
    {
        protected new IAsmContext Context;

        public t_asm_explicit()
        {
            Context = AsmContext.Rooted(this,DefaultComposition.Create());
                                    
        }
   
        public void Execute()
        {
            void OnCaptureEvent(in AsmCaptureEvent data)
            {
                //Trace($"{data.CaptureState}");
            }

            using var buffers = Context.Buffers(OnCaptureEvent);
            OnExecute(buffers);
        }

        protected abstract void OnExecute(in AsmBuffers buffers);

        protected AsmFormatConfig DefaultAsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        protected static IAsmCodeWriter HexTestWriter(IAsmContext context, [Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(typeof(E).Name), test, FileExtensions.Hex);    
            return  context.CodeWriter(dst);
        }

        protected static IAsmEncodingWriter RawTestWriter(IAsmContext context, [Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(typeof(E).Name), test, FileExtensions.Raw);    
            return  context.RawWriter(dst);
        }

        protected static IAsmFunctionWriter AsmTestWriter(IAsmContext context, [Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(typeof(E).Name), test, FileExtensions.Asm);
            var format = AsmFormatConfig.Default.WithFunctionTimestamp();
            return context.WithFormat(format).AsmWriter(path);
        }
    }
}