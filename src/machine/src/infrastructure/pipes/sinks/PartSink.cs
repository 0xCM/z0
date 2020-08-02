//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct PartSink : IAppEventSink<AppEvent<BinaryCode>>, IServiceAllocation
    {
        readonly FilePath Standard;

        readonly FilePath ErrorPath;

        readonly PartFileWriter<BinaryCode> Writer;

        readonly object Locker;

        public PartSink(IAppContext context)
            : this(context.AppPaths.AppStandardOutPath, context.AppPaths.AppErrorOutPath)
        {

        }        

        public PartSink(FilePath standard, FilePath error)
        {
            Standard = standard;
            ErrorPath = error;
            Writer = standard.Writer<BinaryCode>();
            Locker = new object();
        }

        public void Deposit(IAppEvent e)
        {
            lock(Locker)
                Writer.WriterLine(e.Format());            
        }

        public void Deposit(AppEvent<BinaryCode> e)
        {
            lock(Locker)
                Writer.WriterLine(e.Payload);
        }

        public void Dispose()
        {
            Writer.Dispose();
        }
    }
}